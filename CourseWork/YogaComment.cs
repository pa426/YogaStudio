using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseWork
{
    public class YogaComment
    {//Class permiting to manipulate comments
        private int commnetId;

        public int CommnetId
        {
            get { return commnetId; }
            set { commnetId = value; }
        }
        private YogaNames userName;

        public YogaNames UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        private DateTime addTime;

        public DateTime AddTime
        {
            get { return addTime; }
            set { addTime = value; }
        }

        public YogaComment(int cId, YogaNames n, string c, DateTime d)
        {
            commnetId = cId;
            userName = n;
            comment = c;
            addTime = d;

        }
    }
}