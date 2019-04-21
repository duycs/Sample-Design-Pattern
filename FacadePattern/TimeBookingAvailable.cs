using System;

namespace Sample_Design_Pattern.FacadePattern
{
    //a sub system
    public class TimeBookingAvailable
    {
        public bool IsTimeBookingAvailable(string dateTimeBooking){
            //check time booking is avalible
            Console.WriteLine($"Time booking {dateTimeBooking} is available");
            return true;
        }
    }
}