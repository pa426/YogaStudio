using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Login : System.Web.UI.Page
    {
        private string password;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {//Method used to verify users details and store them in Sessions

            password = TextBox2.Text;
            string[] userDetails = DBConn.CheckUser(TextBox1.Text);

            if (password == userDetails[0])
            {
                Session["UsernameLogin"] = TextBox1.Text;
                Session["UserType"] = userDetails[1];
                Session["UserID"] = userDetails[2];
                ScriptManager.RegisterStartupScript(this, GetType(), "Welcome", "confirm('Welcome back  " + TextBox1.Text + " !');", true);//Introdu if cu raspuns
                Response.Redirect("Default.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "error", "alert('Please insert a valid username or password!');", true);
            }


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}