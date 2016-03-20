using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseWork
{//Class used to manipulate existing classes and create new ones
    public class YogaClass
    {
        private int classId;

        public int ClassId
        {
            get { return classId; }
            set { classId = value; }
        }

        private DateTime classTime;

        public DateTime ClassTime
        {
            get { return classTime; }
            set { classTime = value; }
        }
        private string className;

        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }

        private YogaNames classTeacher;

        public YogaNames ClassTeacher
        {
            get { return classTeacher; }
            set { classTeacher = value; }
        }

        private int classLevel;

        public int ClassLevel
        {
            get { return classLevel; }
            set { classLevel = value; }
        }
        private string classDuration;

        public string ClassDuration
        {
            get { return classDuration; }
            set { classDuration = value; }
        }
        private string classDescription;

        public string ClassDescription
        {
            get { return classDescription; }
            set { classDescription = value; }
        }
        private int classPlacesLeft;

        public int ClassPlacesLeft
        {
            get { return classPlacesLeft; }
            set { classPlacesLeft = value; }
        }
        private int classStatus;

        public int ClassStatus
        {
            get { return classStatus; }
            set { classStatus = value; }
        }

        public YogaClass(int id, DateTime da, string na, YogaNames t, int lev, string dur, string des, int pla)
        {
            classId = id;
            classTime = da;
            className = na;
            classTeacher = t;
            classLevel = lev;
            classDuration = dur;
            classDescription = des;
            classPlacesLeft = pla;

        }

    }
}