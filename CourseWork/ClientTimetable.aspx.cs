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
    public partial class Timetable : System.Web.UI.Page
    {

        private List<YogaClass> classes;
        private List<YogaWorkshop> workshops;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UsernameLogin"] == null && Session["UserType"] == null)
            {
                Label1.Visible = true;
                Label2.Visible = false;
                Label3.Visible = false;
            }
            else
            {
                Label1.Visible = false;
                Label2.Visible = true;
                Label3.Visible = true;
            }

            if (!IsPostBack)
            {
                classes = DBConn.LoadAllClasses();
                YogaClasses();
                classes = DBConn.LoadBookedClasses((string)Session["UsernameLogin"], 0);
                YogaBookedClasses();
                classes = DBConn.LoadBookedClasses((string)Session["UsernameLogin"], 1);
                YogaWaitingClasses();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DropDownList1.SelectedValue)
            {
                case "1":
                    classes = DBConn.LoadAllClasses();
                    YogaClasses();
                    break;
                case "2":
                    workshops = DBConn.LoadAllWorkshops();
                    YogaWorkshops();
                    break;
                case "3":
                    classes = DBConn.LoadBookedClasses((string)Session["UsernameLogin"],0);
                    YogaBookedClasses();
                    break;
                case "4":
                    workshops = DBConn.LoadBookedWorkshops((string)Session["UsernameLogin"],0);
                    YogaBookedWorkshops();
                    break;
                case "5":
                    classes = DBConn.LoadBookedClasses((string)Session["UsernameLogin"], 1);
                    YogaWaitingClasses();
                    break;
                case "6":
                    workshops = DBConn.LoadBookedWorkshops((string)Session["UsernameLogin"], 1);
                    YogaWaitingWorkshops();
                    break;
                default:
                    break;
            }

        }

        public  void YogaClasses()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime)); 
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Teacher", typeof(string));
            dt.Columns.Add("Level", typeof(int));
            dt.Columns.Add("Duration", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("Places", typeof(int));


            if (classes != null)
            {
                foreach (var cl in classes)
                {

                    DataRow row1 = dt.NewRow();
                    row1["ID"] = cl.ClassId;
                    row1["Date"] = cl.ClassTime;
                    row1["Name"] = cl.ClassName;
                    row1["Teacher"] = cl.ClassTeacher.Name;
                    row1["Level"] = cl.ClassLevel;
                    row1["Duration"] = cl.ClassDuration;
                    row1["Description"] = cl.ClassDescription;
                    row1["Places"] = cl.ClassPlacesLeft;

                    dt.Rows.Add(row1);

                }
            }

            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        public void YogaWorkshops()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime)); 
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Teacher", typeof(string));
            dt.Columns.Add("Duration", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("Places", typeof(int));


            if (workshops != null)
            {
                foreach (var cl in workshops)
                {

                    DataRow row1 = dt.NewRow();
                    row1["ID"] = cl.WorkshopId;
                    row1["Date"] = cl.WorkshopTime;
                    row1["Name"] = cl.WorkshopName;
                    row1["Teacher"] = cl.WorkTeacher.Name;
                    row1["Duration"] = cl.WorkshopDuration;
                    row1["Description"] = cl.WorkshopDescription;
                    row1["Places"] = cl.WorkshopPlacesLeft;
                    dt.Rows.Add(row1);

                }
            }

            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        private void YogaBookedClasses()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime)); 
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Teacher", typeof(string));
            dt.Columns.Add("Level", typeof(int));
            dt.Columns.Add("Duration", typeof(string));
            dt.Columns.Add("Description", typeof(string));


            if (classes != null)
            {
                foreach (var cl in classes)
                {
                    DataRow row1 = dt.NewRow();
                    row1["ID"] = cl.ClassId;
                    row1["Date"] = cl.ClassTime;
                    row1["Name"] = cl.ClassName;
                    row1["Teacher"] = cl.ClassTeacher.Name;
                    row1["Level"] = cl.ClassLevel;
                    row1["Duration"] = cl.ClassDuration;
                    row1["Description"] = cl.ClassDescription;

                    dt.Rows.Add(row1);

                }
            }

            GridView2.DataSource = dt;
            GridView2.DataBind();

        }

        private void YogaBookedWorkshops()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime)); 
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Teacher", typeof(string));
            dt.Columns.Add("Duration", typeof(string));
            dt.Columns.Add("Description", typeof(string));

            if (workshops != null)
            {
                foreach (var cl in workshops)
                {

                    DataRow row1 = dt.NewRow();
                    row1["ID"] = cl.WorkshopId;
                    row1["Date"] = cl.WorkshopTime;
                    row1["Name"] = cl.WorkshopName;
                    row1["Teacher"] = cl.WorkTeacher.Name;
                    row1["Duration"] = cl.WorkshopDuration;
                    row1["Description"] = cl.WorkshopDescription;

                    dt.Rows.Add(row1);

                }
            }

            GridView2.DataSource = dt;
            GridView2.DataBind();

        }

        private void YogaWaitingClasses()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime)); 
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Teacher", typeof(string));
            dt.Columns.Add("Level", typeof(int));
            dt.Columns.Add("Duration", typeof(string));
            dt.Columns.Add("Description", typeof(string));


            if (classes != null)
            {
                foreach (var cl in classes)
                {

                    DataRow row1 = dt.NewRow();
                    row1["ID"] = cl.ClassId;
                    row1["Date"] = cl.ClassTime;
                    row1["Name"] = cl.ClassName;
                    row1["Teacher"] = cl.ClassTeacher.Name;
                    row1["Level"] = cl.ClassLevel;
                    row1["Duration"] = cl.ClassDuration;
                    row1["Description"] = cl.ClassDescription;


                    dt.Rows.Add(row1);

                }
            }

            GridView3.DataSource = dt;
            GridView3.DataBind();

        }

        private void YogaWaitingWorkshops()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime)); 
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Teacher", typeof(string));
            dt.Columns.Add("Duration", typeof(string));
            dt.Columns.Add("Description", typeof(string));

            if (workshops != null)
            {
                foreach (var cl in workshops)
                {

                    DataRow row1 = dt.NewRow();
                    row1["ID"] = cl.WorkshopId;
                    row1["Date"] = cl.WorkshopTime;
                    row1["Name"] = cl.WorkshopName;
                    row1["Teacher"] = cl.WorkTeacher.Name;
                    row1["Duration"] = cl.WorkshopDuration;
                    row1["Description"] = cl.WorkshopDescription;

                    dt.Rows.Add(row1);

                }
            }

            GridView3.DataSource = dt;
            GridView3.DataBind();

        }


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cwId = int.Parse(GridView1.SelectedRow.Cells[1].Text);
            int noOfColumns = GridView1.Rows[1].Cells.Count;
            string uName = (string)Session["UsernameLogin"];
            int resCount = 0;
            bool reservationTest = false;

            

       
            DialogResult result = MessageBox.Show("Do you want to book this session?", "Confirmation", MessageBoxButtons.YesNo);
            if (noOfColumns == 9 && Session["UserType"] != null)
            {
                int classLimit = int.Parse(GridView1.SelectedRow.Cells[8].Text);
                if (result == DialogResult.Yes)
                {
                    List<YogaReservations> reservation = DBConn.LoadClassWaitingListNr(cwId);
                    foreach (var tst in reservation)
                    {
                      
                        if (uName == tst.UsId)//Test if user is already booked
                        {
                            reservationTest = true;
                        }
                    }
                    
                    if (reservation != null)
                    {
                        resCount = reservation.Count;
                    }
                                        

                    if (resCount< classLimit )//Test if there are any more avilable booking places
                    {
                        if (reservationTest == true)
                        {
                            MessageBox.Show("You are already booked for this class!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DBConn.SaveClassBooking((string)Session["UsernameLogin"], cwId,0);
                        }
                    }
                    else
                    {
                        DialogResult result1 = MessageBox.Show("No more places available would you like to be added in the waiting list?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            DBConn.SaveClassBooking((string)Session["UsernameLogin"], cwId, 1);
                        }
                    }
                }
            }
            else if (noOfColumns == 8 && Session["UserType"] != null)
            {
               
                if (result == DialogResult.Yes)
                {
                    int classLimit = int.Parse(GridView1.SelectedRow.Cells[7].Text);
                    List<YogaReservations> reservation = DBConn.LoadWorkshopWaitingListNr(cwId);
                    foreach (var tst in reservation)
                    {
                        System.Diagnostics.Debug.WriteLine(tst);
                        if (uName == tst.UsId)
                        {
                            reservationTest = true;
                        }
                    }

                    if (reservation != null)
                    {
                        resCount = reservation.Count;
                    }

                    if (resCount < classLimit)
                    {
                        if (reservationTest == true)
                        {
                            MessageBox.Show("You are already booked for this workshop!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DBConn.SaveWorkshopBooking((string)Session["UsernameLogin"], cwId,0);
                        }
                    }
                    else
                    {
                        DialogResult result1 = MessageBox.Show("No more places available would you like to be added in the waiting list?", "Confirmation", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            DBConn.SaveWorkshopBooking((string)Session["UsernameLogin"], cwId, 1);
                        }
                    }

                    
                }
            }
            else
            {
                MessageBox.Show("Please log in to manipulate bookings", "Log in Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cwId = int.Parse(GridView2.SelectedRow.Cells[1].Text);
            int noOfColumns = GridView2.Rows[0].Cells.Count;
            DateTime date1 = DateTime.Parse(GridView2.SelectedRow.Cells[2].Text);
            DateTime date2 = DateTime.Now;
            double testHours = (date1 - date2).TotalHours;//Calculate difference between class date and actual date

            if (testHours > 24)//Test in the hour limit was overcome
            {
                DialogResult result = MessageBox.Show("Do you want to delete your Booking?", "Confirmation", MessageBoxButtons.YesNo);
                if (noOfColumns == 8 && Session["UsernameLogin"] != null)
                {
                    if (result == DialogResult.Yes)
                    {

                        List<YogaReservations> r = DBConn.TestClassWaitingList(cwId);//List that tests if there are clients on the waiting page
                       
                        if (r.Count > 0)
                        {
                            int x = int.Parse(r.First().ReservationId.ToString());
                            DBConn.UpdateWaitingListClasses(x);
                        }

                        DBConn.DeleteYogaClassReservation((string)Session["UsernameLogin"], cwId);
                    }
                }
                else if (noOfColumns == 7 && Session["UsernameLogin"] != null)
                {
                    if (result == DialogResult.Yes)
                    {
                        List<YogaReservations> r = DBConn.TestWorkshopWaitingList(cwId);

                        if (r.Count > 0)
                        {
                            int x = int.Parse(r.First().ReservationId.ToString());
                            DBConn.UpdateWaitingListWorkshops(x);
                        }
                        DBConn.DeleteYogaWorkshopReservation((string)Session["UsernameLogin"], cwId);
                    }
                }
                else
                {
                    MessageBox.Show("Please log in to manipulate bookings", "Log in Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The 24 hour limit for booking is passed!", "Hour limit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}