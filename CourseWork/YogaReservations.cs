using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseWork
{//Class used to count and manipulate existing reservations 
    public class YogaReservations
    {
        private int reservationId;

        public int ReservationId
        {
            get { return reservationId; }
            set { reservationId = value; }
        }

        private string usId;

        public string UsId
        {
            get { return usId; }
            set { usId = value; }
        }


        public YogaReservations(int resId, string uId)
        {
            reservationId = resId;
            usId = uId;
        }
    }
}