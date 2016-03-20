using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;

namespace CourseWork
{
    public class DBConn
    {

        private static OleDbConnection GetConnection()
        {
            string connString;
            //  change to your connection string in the following line
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source=I:\COMP 1551 Applications and Web Development\Coursework\CourseWork\YogaStudioDatabaseExample.mdb";
            return new OleDbConnection(connString);
        }


        public static void SaveUser(string n, string sn, string ad, string tel, string eml, int gen, int age, int exp, string hi, int ut, string pass)
        {//method used to save a users detail
            OleDbConnection myConnection = GetConnection();
            string myQuery = " INSERT INTO YogaUser (Name, Surname, Address, PhoneNumber, Email, Gender, Age, Experience, HealthIssue, UserType, [Password]) VALUES ( '" + n + "' , '" + sn + "',  '" + ad + "',  '" + tel + "',  '" + eml + "',  " + gen + ", " + age + ",  " + exp + ",  '" + hi + "',  " + ut + ",  '" + pass + "');";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }
        }


        public static string[] CheckUser(string email)
        {//method used to chek a users detail

            OleDbConnection myConnection = GetConnection();
            string myQuery = " SELECT * FROM YogaUser where Email='" + email + "'";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            string[] userDetails = new string[3];

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {

                    userDetails[0] = myReader["Password"].ToString();
                    userDetails[1] = myReader["Usertype"].ToString();
                    userDetails[2] = myReader["ID"].ToString();

                }
                return userDetails;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static List<YogaClass> LoadAllClasses()
        {//method used to load clases from data base in lists
            List<YogaClass> classes = new List<YogaClass>();
            List<YogaNames> teachers = ListTeachers();

            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM YogaClass WHERE NOW() <= ClassStartingTime ORDER BY ClassStartingTime";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {

                    YogaNames currentTeacher = FindTeacher(teachers, int.Parse(myReader["StaffID"].ToString()));

                    YogaClass c = new YogaClass((int.Parse(myReader["ClassID"].ToString())), DateTime.Parse(myReader["ClassStartingTime"].ToString()), myReader["ClassName"].ToString(), currentTeacher, (int.Parse(myReader["ClassLevel"].ToString())), (myReader["ClassDuration"].ToString()), myReader["ClassDescription"].ToString(), (int.Parse(myReader["ClassPlacesAvailable"].ToString())));
                    classes.Add(c);

                }
                return classes;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }


        }



        public static List<YogaWorkshop> LoadAllWorkshops()
        {//method used to load workshops from data base in lists
            List<YogaWorkshop> workshop = new List<YogaWorkshop>();
            List<YogaNames> teachers = ListTeachers();
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM YogaWorkshop WHERE NOW() <= WorkshopTime ORDER BY WorkshopTime";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    YogaNames currentTeacher = FindTeacher(teachers, int.Parse(myReader["StaffID"].ToString()));
                    YogaWorkshop w = new YogaWorkshop((int.Parse(myReader["WorkshopID"].ToString())), DateTime.Parse(myReader["WorkshopTime"].ToString()), myReader["WorkshopName"].ToString(), currentTeacher, (myReader["WorkshopDuration"].ToString()), myReader["WorkshopDescription"].ToString(), (int.Parse(myReader["WorkshopPlacesAvailable"].ToString())));
                    workshop.Add(w);

                }
                return workshop;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }


        public static List<YogaClass> LoadBookedClasses(string username, int wStatus )
        {//method used to load  booked clases from data base in lists
            List<YogaClass> classes = new List<YogaClass>();
            List<YogaNames> teachers = ListTeachers();
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM YogaClass LEFT JOIN YogaClassReservation ON YogaClass.ClassID=YogaClassReservation.YogaClassID WHERE CClientUsername = '" + username + "' AND ClassWaitinglistStatus =" + wStatus + ";";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    YogaNames currentTeacher = FindTeacher(teachers, int.Parse(myReader["StaffID"].ToString()));
                    YogaClass c = new YogaClass((int.Parse(myReader["ClassID"].ToString())), DateTime.Parse(myReader["ClassStartingTime"].ToString()), myReader["ClassName"].ToString(), currentTeacher, (int.Parse(myReader["ClassLevel"].ToString())), (myReader["ClassDuration"].ToString()), myReader["ClassDescription"].ToString(), (int.Parse(myReader["ClassPlacesAvailable"].ToString())));
                    classes.Add(c);

                }
                return classes;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }


        }


        public static List<YogaWorkshop> LoadBookedWorkshops(string username, int wStatus)
        {//method used to load booked workshops from data base in lists
            List<YogaWorkshop> workshop = new List<YogaWorkshop>();
            List<YogaNames> teachers = ListTeachers();
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM YogaWorkshop LEFT JOIN YogaWorkshopReservation ON YogaWorkshop.WorkshopID=YogaWorkshopReservation.YogaWorkshopID WHERE WClientUsername = '" + username + "' AND WorkshopWaitinglistStatus =" + wStatus + ";";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    YogaNames currentTeacher = FindTeacher(teachers, int.Parse(myReader["StaffID"].ToString()));
                    YogaWorkshop w = new YogaWorkshop((int.Parse(myReader["WorkshopID"].ToString())), DateTime.Parse(myReader["WorkshopTime"].ToString()), myReader["WorkshopName"].ToString(), currentTeacher, (myReader["WorkshopDuration"].ToString()), myReader["WorkshopDescription"].ToString(), (int.Parse(myReader["WorkshopPlacesAvailable"].ToString())));
                    workshop.Add(w);

                }
                return workshop;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static void SaveClassBooking(string uN, int cId, int wSts )
        {//method used to save booking of clases in the data base 
            OleDbConnection myConnection = GetConnection();
            string myQuery = "INSERT INTO YogaClassReservation(CClientUsername, YogaClassID, ClassWaitinglistStatus) VALUES ( '" + uN + "' , " + cId + ", " + wSts + ")";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }
        }


        public static void SaveWorkshopBooking(string uN, int wId, int wSts)
        {//method used to save booking of workshops in the data base 
            OleDbConnection myConnection = GetConnection();
            string myQuery = "INSERT INTO YogaWorkshopReservation(WClientUsername, YogaWorkshopID, WorkshopWaitinglistStatus) VALUES ( '" + uN + "' , " + wId + ", " + wSts + ")";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }
        }


        public static void DeleteYogaClassReservation(string uN, int cId)
        {//method used to delete booking of classes in the data base 
            OleDbConnection myConnection = GetConnection();
            string myQuery = "DELETE * FROM YogaClassReservation  WHERE  CClientUsername = '" + uN + "' AND YogaClassID = " + cId;
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);


            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }

        }

        public static void DeleteYogaWorkshopReservation(string uN, int cId)
        {//method used to delete booking of workshops in the data base 
            OleDbConnection myConnection = GetConnection();
            string myQuery = "DELETE * FROM YogaWorkshopReservation  WHERE  WClientUsername = '" + uN + "' AND YogaWorkshopID = " + cId;
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);


            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }

        }


        public static List<YogaReservations> LoadClassWaitingListNr(int cId)
        {//Method used to count the bookings
            List<YogaReservations> reservation = new List<YogaReservations>();
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT ClassReservationID, CClientUsername FROM YogaClassReservation WHERE YogaClassID =" + cId;
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    YogaReservations w = new YogaReservations((int.Parse(myReader["ClassReservationID"].ToString())), (myReader["CClientUsername"].ToString()));
                    reservation.Add(w);

                }
                return reservation;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }


        public static List<YogaReservations> LoadWorkshopWaitingListNr(int cId)
        {//Method used to count the bookings
            List<YogaReservations> reservation = new List<YogaReservations>();
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT WorkshopReservationID, WClientUsername FROM YogaWorkshopReservation WHERE YogaWorkshopID =" + cId;
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    YogaReservations w = new YogaReservations((int.Parse(myReader["WorkshopReservationID"].ToString())), (myReader["WClientUsername"].ToString()));
                    reservation.Add(w);

                }
                return reservation;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }


        public static List<YogaReservations> TestClassWaitingList(int cId)
        {//Method used to verify the bookings
            List<YogaReservations> reservation = new List<YogaReservations>();
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT ClassReservationID, CClientUsername FROM YogaClassReservation WHERE YogaClassID =" + cId + " AND ClassWaitinglistStatus =1";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    YogaReservations w = new YogaReservations((int.Parse(myReader["ClassReservationID"].ToString())), (myReader["CClientUsername"].ToString()));
                    reservation.Add(w);

                }
                return reservation;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }


        public static List<YogaReservations> TestWorkshopWaitingList(int cId)
        {//Method used to verify the bookings
            List<YogaReservations> reservation = new List<YogaReservations>();
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT WorkshopReservationID, WClientUsername FROM YogaWorkshopReservation WHERE YogaWorkshopID =" + cId + " AND WorkshopWaitinglistStatus =1";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    YogaReservations w = new YogaReservations((int.Parse(myReader["WorkshopReservationID"].ToString())), (myReader["WClientUsername"].ToString()));
                    reservation.Add(w);

                }
                return reservation;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }


        public static void UpdateWaitingListClasses( int rId)
        {//Method used to modify the reservation status from waiting list to booked

            OleDbConnection myConnection = GetConnection();
            string myQuery = "UPDATE  YogaClassReservation SET ClassWaitinglistStatus =0 WHERE ClassReservationID = " + rId;
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }

        }


        public static void UpdateWaitingListWorkshops(int rId)
        {//Method used to modify the reservation status from waiting list to booked

            OleDbConnection myConnection = GetConnection();
            string myQuery = "UPDATE  YogaWorkshopReservation SET WorkshopWaitinglistStatus =0 WHERE WorkshopReservationID = " + rId;
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }

        }


        public static void DeleteYogaClass(int cId)
        {//Method used to delete classes
            OleDbConnection myConnection = GetConnection();
            string myQuery = "DELETE * FROM YogaClass WHERE ClassID =" + cId;
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);


            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }

        }

        public static void DeleteYogaWorkshop( int wId)
        {//Method used to delete workshops
            OleDbConnection myConnection = GetConnection();
            string myQuery = "DELETE * FROM YogaWorkshop WHERE WorkshopID =" + wId;
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);


            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }

        }


        public static void CancelClass(int cId)
        {//Method used to cancel classes

            OleDbConnection myConnection = GetConnection();
            string myQuery = "UPDATE  YogaClass SET ClassDescription = 'Class Canceled', ClassDuration = 'Class Canceled'  WHERE ClassID = " + cId;
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }

        }


        public static void CancelWorkshop(int wId)
        {//Method used to cancel workshops

            OleDbConnection myConnection = GetConnection();
            string myQuery = "UPDATE  YogaWorkshop SET WorkshopDescription = 'Workshop Canceled', WorkshopDuration = 'Workshop Canceled' WHERE WorkshopID = " + wId;
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }

        }


        public static List<YogaNames> ListTeachers()
        { //Method used to list teachers

            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM YogaUser where UserType =2";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            List<YogaNames> t = new List<YogaNames>();

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {

                    YogaNames w = new YogaNames((int.Parse(myReader["ID"].ToString())), (myReader["Name"].ToString()), (myReader["Surname"].ToString()));
                    t.Add(w);

                }
                return t;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }



        public static List<YogaNames> ListUsers()
        { //Method used to list users

            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM YogaUser";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            List<YogaNames> t = new List<YogaNames>();

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {

                    YogaNames w = new YogaNames((int.Parse(myReader["ID"].ToString())), (myReader["Name"].ToString()), (myReader["Surname"].ToString()));
                    t.Add(w);

                }
                return t;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }


        private static YogaNames FindTeacher(List<YogaNames> teachers, int id)
        {//Method used to find teachers name
            foreach (var tcr in teachers)
            {
                if (tcr.UserId == id)
                {
                    return tcr;
                }
            }
            return null;
        }


        public static void SaveClass(DateTime d, string cn, int sId, int  lev, string dura, string  des, int plAv)
        {//Methos used to save class 
            OleDbConnection myConnection = GetConnection();
            string myQuery = " INSERT INTO YogaClass (ClassStartingTime, ClassName, StaffID, ClassLevel, ClassDuration, ClassDescription, ClassPlacesAvailable) VALUES ( #" + d + "# , '" + cn + "',  " + sId + ",  " + lev + ",  '" + dura + "', '" + des + "', " + plAv + ");";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }
        }


        public static void SaveWorkshop(DateTime d, string cn, int sId, string dura, string des, int plAv)
        {//Methos used to save workshop
            OleDbConnection myConnection = GetConnection();
            string myQuery = " INSERT INTO YogaWorkshop (WorkshopTime, WorkshopName, StaffID, WorkshopDuration, WorkshopDescription, WorkshopPlacesAvailable) VALUES ( #" + d + "#, '" + cn + "',  " + sId + ",  '" + dura + "', '" + des + "', " + plAv + ");";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }
        }


        public static List<YogaComment> LoadAllComents()
        {//Method used to read comments
            List<YogaComment> comments = new List<YogaComment>();
            List<YogaNames> users = ListUsers();


            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT * FROM YogaComments";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    YogaNames currentUser = FindTeacher(users, int.Parse(myReader["YogaUserID"].ToString()));

                    YogaComment c = new YogaComment((int.Parse(myReader["CommentID"].ToString())), currentUser, (myReader["Comment"].ToString()), (DateTime.Parse(myReader["AddDate"].ToString())));
                    comments.Add(c);

                }
                return comments;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }


        }

        public static void WriteComment(int uId, string comment)
        { //Method used to write comments

            OleDbConnection myConnection = GetConnection();
            string myQuery = " INSERT INTO YogaComments (YogaUserID, Comment) VALUES ( '" + uId + "' , '" + comment + "');";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }

        }


        public static void DeleteComment(int cId)
        {//Method used to delete comments
            OleDbConnection myConnection = GetConnection();
            string myQuery = "DELETE * FROM YogaComments WHERE CommentID =" + cId;
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);


            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }

        }
    }
}