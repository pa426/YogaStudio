using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseWork
{//Class used to manipulate existing workshops and create new ones
    public class YogaWorkshop
    {
        private int workshopId;

        public int WorkshopId
        {
            get { return workshopId; }
            set { workshopId = value; }
        }

        private DateTime workshopTime;

        public DateTime WorkshopTime
        {
            get { return workshopTime; }
            set { workshopTime = value; }
        }
        private string workshopName;

        public string WorkshopName
        {
            get { return workshopName; }
            set { workshopName = value; }
        }

        private YogaNames workshopTeacher;

        public YogaNames WorkTeacher
        {
            get { return workshopTeacher; }
            set { workshopTeacher = value; }
        }


        private string workshopDuration;

        public string WorkshopDuration
        {
            get { return workshopDuration; }
            set { workshopDuration = value; }
        }
        private string workshopDescription;

        public string WorkshopDescription
        {
            get { return workshopDescription; }
            set { workshopDescription = value; }
        }
        private int workshopPlacesLeft;

        public int WorkshopPlacesLeft
        {
            get { return workshopPlacesLeft; }
            set { workshopPlacesLeft = value; }
        }
        private int workshopStatus;

        public int WorkshopStatus
        {
            get { return workshopStatus; }
            set { workshopStatus = value; }
        }


        public YogaWorkshop(int id, DateTime da, string na, YogaNames t, string dur, string des, int pla)
        {
            workshopId = id;
            workshopTime = da;
            workshopName = na;
            workshopTeacher = t;
            workshopDuration = dur;
            workshopDescription = des;
            workshopPlacesLeft = pla;


        }


    }

}