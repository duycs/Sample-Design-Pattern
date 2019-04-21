using System;

namespace Sample_Design_Pattern.ObserverPattern.BookingObserverPattern
{
    //concrete Observer
    class Customer : ICustomer
    {
        private Booking _booking;

        public Customer(Booking booking){
            _booking = booking;
        }
        public void Update()
        {
            if(_booking.NumberCanBook <= _booking.NumberMax){
                Console.WriteLine($"Time {_booking.Time} can book");
            }else {
                Console.WriteLine($"Time {_booking.Time} can't book");
            }
        }
    }
}