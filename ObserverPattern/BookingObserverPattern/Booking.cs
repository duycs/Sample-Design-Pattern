namespace SampleDesignPattern.ObserverPattern.BookingObserverPattern
{
    //concrete Subject
    class Booking : BookingTime
    {
        public Booking(string time):base(time){}
    }
}