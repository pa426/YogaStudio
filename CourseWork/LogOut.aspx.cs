using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseWork
{
    public partial class LogOut : System.Web.UI.Page
    {//Class used to delete data stored in sessions
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["UsernameLogin"] = null;
            Session["UserType"] = null;
            Response.Redirect("Default.aspx");
        }
    }
}