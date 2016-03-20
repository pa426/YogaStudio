using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseWork
{
    public partial class SiteMaster : MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {// Method used to manipulate the master page buttons visibility


            if (Session["UsernameLogin"] != null && Session["UserType"] != null)
            {
                usernameLabel.Text = "Welcome back: " + Session["UsernameLogin"].ToString();

                var testDiv1 = LoginView.FindControl("registerLink");
                
                var testDiv2 = LoginView.FindControl("loginLink");
                testDiv2.Visible = false;
                var testDiv3 = LoginView1.FindControl("logoutLink");
                testDiv3.Visible = true;

                if (Session["UserType"].ToString() == "1")
                {
                    TimetableLink.HRef = "~/ClientTimetable";
                    testDiv1.Visible = false;
                }
                else if (Session["UserType"].ToString() == "2")
                {
                    TimetableLink.HRef = "~/StaffTimetable";
                    testDiv1.Visible = true;
                }
            }
            else
            {
                var testDiv1 = LoginView.FindControl("registerLink");
                testDiv1.Visible = true;
                var testDiv2 = LoginView.FindControl("loginLink");
                testDiv2.Visible = true;
                var testDiv3 = LoginView1.FindControl("logoutLink");
                testDiv3.Visible = false;
            }

            


        }

    }
}