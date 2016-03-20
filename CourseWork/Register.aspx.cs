using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Register : System.Web.UI.Page
    {//Class used to insert data in the database and create differet tipe of users

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UsernameLogin"] != null )
            {
                if (Session["UserType"].ToString() == "2")
                {
                    CheckBoxList2.Visible = true;
                    Label3.Visible = true;
                }
                else
                {
                    CheckBoxList2.Visible = false;
                    Label3.Visible = false;

                }
            }
            else
            {
                CheckBoxList2.Visible = false;
                Label3.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (TextBox8.Text == TextBox9.Text)
            {
  
                if (Session["UserType"].ToString() == "2")
                {
                    DBConn.SaveUser(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, int.Parse(CheckBoxList1.SelectedValue), int.Parse(TextBox6.Text),
                    int.Parse(CheckBoxList3.SelectedValue), TextBox7.Text, int.Parse(CheckBoxList2.SelectedValue), TextBox9.Text);
                }
                else
                {
                    DBConn.SaveUser(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, int.Parse(CheckBoxList1.SelectedValue), int.Parse(TextBox6.Text),
                   int.Parse(CheckBoxList3.SelectedValue), TextBox7.Text, 1, TextBox9.Text);
                }

               

                ScriptManager.RegisterStartupScript(this, GetType(), "error", "alert('Your profille was created!');", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "error", "alert('Please match the passwords');", true);
            }
        }
    }
}