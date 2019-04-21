namespace Sample_Design_Pattern.ObserverPattern.BookingObserverPattern
{
    //concrete Subject
    class Booking : BookingTime
    {
        public Booking(string time):base(time){}
    }
}