using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Windows.Forms;



namespace CourseWork
{
    public partial class StaffTimetable : System.Web.UI.Page
    {

        

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false; Label2.Visible = false; Label3.Visible = false; Label4.Visible = false; Label5.Visible = false; Label6.Visible = false; Label7.Visible = false; Label8.Visible = false;
            TextBox1.Visible = false; TextBox2.Visible = false; DropDownList2.Visible = false; DropDownList3.Visible = false; TextBox3.Visible = false; TextBox4.Visible = false; DropDownList4.Visible = false; DropDownList5.Visible = false; Button1.Visible = false; GridView1.Visible = false; GridView2.Visible = false;


            if (!Page.IsPostBack)
            {
                DropDownList2.DataSource = DBConn.ListTeachers();
                DropDownList2.DataTextField = "Name";
                DropDownList2.DataValueField = "UserId"; 
                DropDownList2.DataBind();

            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DropDownList1.SelectedValue)
            {
                case "1":

                    Label1.Visible = true;Label2.Visible = true;Label3.Visible = true;Label4.Visible = true;Label5.Visible = true;Label6.Visible = true;Label7.Visible = true; Label8.Visible = true;
                    TextBox1.Visible = true;TextBox2.Visible = true;DropDownList2.Visible = true; DropDownList3.Visible = true; TextBox3.Visible = true; TextBox4.Visible = true; DropDownList4.Visible = true;Button1.Visible = true; DropDownList5.Visible = true;GridView1.Visible = false; GridView2.Visible = false;
                    Label1.Text = "Class starting time:";    
                    Label2.Text = "Class Name:";            
                    Label3.Text = "Class Teacher:";          
                    Label4.Text = "Class Level:";           
                    Label5.Text = "Class duration:";         
                    Label6.Text = "Class description:";

                    break;
                case "2":
                    Label1.Visible = true;Label2.Visible = true;Label3.Visible = true;Label4.Visible = false;Label5.Visible = true;Label6.Visible = true;Label7.Visible = true; Label8.Visible = false;  
                    TextBox1.Visible = true;TextBox2.Visible = true;DropDownList2.Visible = true; DropDownList3.Visible = false; TextBox3.Visible = true; TextBox4.Visible = true; DropDownList4.Visible = true;Button1.Visible = true; DropDownList5.Visible = false;GridView1.Visible = false;GridView2.Visible = false;
                    Label1.Text = "Workshop starting time:";
                    Label2.Text = "Workshop Name:";
                    Label3.Text = "Workshop Teacher:";
                    Label5.Text = "Workshop duration:";
                    Label6.Text = "Workshop description:";

                    
                    break;
                case "3":
                     Label1.Visible = false; Label2.Visible = false; Label3.Visible = false; Label4.Visible = false; Label5.Visible = false; Label6.Visible = false; Label7.Visible = false; Label8.Visible = false;
                     TextBox1.Visible = false; TextBox2.Visible = false; DropDownList2.Visible = false; DropDownList3.Visible = false; TextBox3.Visible = false; TextBox4.Visible = false; DropDownList4.Visible = false; DropDownList5.Visible = false; Button1.Visible = false; GridView1.Visible = true; GridView2.Visible = false;
                     YogaClasses();
                   

                    break;
                case "4":
                     Label1.Visible = false; Label2.Visible = false; Label3.Visible = false; Label4.Visible = false; Label5.Visible = false; Label6.Visible = false; Label7.Visible = false; Label8.Visible = false;
                     TextBox1.Visible = false; TextBox2.Visible = false; DropDownList2.Visible = false; DropDownList3.Visible = false; TextBox3.Visible = false; TextBox4.Visible = false; DropDownList4.Visible = false; DropDownList5.Visible = false; Button1.Visible = false; GridView1.Visible = true; GridView2.Visible = false;
                     YogaWorkshops();

                    break;
                case "5":
                     Label1.Visible = false; Label2.Visible = false; Label3.Visible = false; Label4.Visible = false; Label5.Visible = false; Label6.Visible = false; Label7.Visible = false; Label8.Visible = false;
                     TextBox1.Visible = false; TextBox2.Visible = false; DropDownList2.Visible = false; DropDownList3.Visible = false; TextBox3.Visible = false; TextBox4.Visible = false; DropDownList4.Visible = false; DropDownList5.Visible = false; Button1.Visible = false; GridView1.Visible = false; GridView2.Visible = true;
                     YogaComments();
                    break;
               
                default:
               
                    break;
            }
        }


        public void YogaClasses()
        {
            List<YogaClass> classes = DBConn.LoadAllClasses();


            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime)); // Make sure this is integer
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Teacher", typeof(string));
            dt.Columns.Add("Level", typeof(int));
            dt.Columns.Add("Duration", typeof(string));
            dt.Columns.Add("Places Left", typeof(int));


           

            foreach (var cl in classes )
            {
             

                DataRow row1 = dt.NewRow();
                row1["ID"] = cl.ClassId;
                row1["Date"] = cl.ClassTime;
                row1["Name"] = cl.ClassName;
                row1["Teacher"] = cl.ClassTeacher.Name;
                row1["Level"] = cl.ClassLevel;
                row1["Duration"] = cl.ClassDuration;
                row1["Places Left"] = cl.ClassPlacesLeft;

                dt.Rows.Add(row1);

            }

            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        public void YogaWorkshops()
        {
            List<YogaWorkshop> workshops = DBConn.LoadAllWorkshops();

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime)); 
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Teacher", typeof(string));
            dt.Columns.Add("Duration", typeof(string));
            dt.Columns.Add("Places avilable", typeof(int));

            foreach (var cl in workshops)
            {

                DataRow row1 = dt.NewRow();
                row1["ID"] = cl.WorkshopId;
                row1["Date"] = cl.WorkshopTime;
                row1["Name"] = cl.WorkshopName;
                row1["Teacher"] = cl.WorkTeacher.Name;
                row1["Duration"] = cl.WorkshopDuration;
                row1["Places avilable"] = cl.WorkshopPlacesLeft;
                dt.Rows.Add(row1);

            }

            GridView1.DataSource = dt;
            GridView1.DataBind();

        }


        public void YogaComments()
        {
            List<YogaComment> comments = DBConn.LoadAllComents();

            DataTable dt = new DataTable();
            dt.Columns.Add("CommentID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Comment", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));

            foreach (var c in comments)
            {

                DataRow row1 = dt.NewRow();
                row1["CommentID"] = c.CommnetId;
                row1["Name"] = c.UserName.Name;
                row1["Comment"] = c.Comment;
                row1["Date"] = c.AddTime;
                
                dt.Rows.Add(row1);

            }

            GridView2.DataSource = dt;
            GridView2.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cwId = int.Parse(GridView1.SelectedRow.Cells[1].Text);
            int noOfColumns = GridView1.Rows[1].Cells.Count;

            MessageBoxManager.Yes = "Remove";
            MessageBoxManager.No = "Cancel meeting";
            MessageBoxManager.Cancel = "Turn back";
            MessageBoxManager.Register();
            DialogResult result = MessageBox.Show("Please select a option", "Confirmation", MessageBoxButtons.YesNoCancel);//mrthod that permits manipulating the text from the buttons
            
            if (result == DialogResult.Yes)
            {
                if (noOfColumns == 8)
                {
                    DBConn.DeleteYogaClass(cwId);
                }
                else
                {
                    DBConn.DeleteYogaWorkshop(cwId); 
                }
                Response.Redirect("StaffTimetable.aspx");

            }
            else if (result == DialogResult.No)
            {
                if (noOfColumns == 8)
                {
                    DBConn.CancelClass(cwId);
                }
                else
                {
                    DBConn.CancelWorkshop(cwId);
                }
                Response.Redirect("StaffTimetable.aspx");
            }



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime courseDate = DateTime.Parse(TextBox1.Text);
            TimeSpan duration = new System.TimeSpan(7, 0, 0, 0);// 7 days difference used to book in one week time
           
            if (DropDownList1.SelectedValue == "1")
            {
                
                for (int i = 0; i < int.Parse(DropDownList5.SelectedValue.ToString()); i++)//for used to upload multiple Classes with differet dates
                {
                   
                    DBConn.SaveClass(courseDate, TextBox2.Text, int.Parse(DropDownList2.SelectedValue), int.Parse(DropDownList3.SelectedValue), TextBox3.Text, TextBox4.Text, int.Parse(DropDownList4.SelectedValue));
                    courseDate = courseDate.Add(duration);
                }


                
                Response.Redirect("StaffTimetable.aspx");
            }
            else if (DropDownList1.SelectedValue == "2")
            {
                DBConn.SaveWorkshop(DateTime.Parse(TextBox1.Text), TextBox2.Text, int.Parse(DropDownList2.SelectedValue), TextBox3.Text, TextBox4.Text, int.Parse(DropDownList4.SelectedValue));
                Response.Redirect("StaffTimetable.aspx");
            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int commId = int.Parse(GridView2.SelectedRow.Cells[1].Text);
            DialogResult result = MessageBox.Show("Do you want to delete this comment?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DBConn.DeleteComment(commId);
                Response.Redirect("StaffTimetable.aspx");
            }
        }

    }
}