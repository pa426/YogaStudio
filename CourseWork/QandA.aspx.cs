using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class QandA : System.Web.UI.Page
    {// Class used to manipulate comments
        protected void Page_Load(object sender, EventArgs e)
        {
            List<YogaComment> comm = DBConn.LoadAllComents();
            String comment = "";
            foreach (var c in comm)
            {
                comment += c.UserName.Name + "<br/>" + c.Comment + "<br/>" + c.AddTime + "<br/><br/>";
            }

            Label1.Text =comment;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["UsernameLogin"] != null && Session["UserType"] != null)
            {
                DBConn.WriteComment( int.Parse(Session["UserID"].ToString()), TextBox2.Text);
                TextBox2.Text = string.Empty;
                Response.Redirect("QandA.aspx");
            }
            else
            {
                MessageBox.Show("Please log in to leave a comment !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox2.Text = string.Empty;
            }


        }
    }
}