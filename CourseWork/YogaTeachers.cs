using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseWork
{// Class used to manipulate teachers and names
    public class YogaNames
    {
        private int userId;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public YogaNames(int uId , string nam, string sur)
        {
            userId = uId;
            name = nam + " " + sur;


        }



    }
}