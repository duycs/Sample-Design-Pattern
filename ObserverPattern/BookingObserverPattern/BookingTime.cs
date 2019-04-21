using System.Collections.Generic;
namespace Sample_Design_Pattern.ObserverPattern.BookingObserverPattern
{
    //abstract Subject
    abstract class BookingTime
    {
        private int _numberCanBook;
        private string _time;
        private readonly int NUMBER_MAX = 2;
        List<ICustomer> customers = new List<ICustomer>();

        public BookingTime(string time){
            _numberCanBook = 0;
            _time = time;
        }
        public void Attach(ICustomer customer){
            customers.Add(customer);
            _numberCanBook ++;
             Notify();
        }

        public void Detach(ICustomer customer){
            customers.Remove(customer);
            _numberCanBook --;
             Notify();
        }

        public void Notify(){
            foreach(var c in customers){
                c.Update();
            }
        }

        public int NumberCanBook{
            get{return _numberCanBook;}
            set{
                _numberCanBook=value;
            }
        }

        public int NumberMax {
            get{return NUMBER_MAX;}
        }

        public string Time{
            get{return _time;}
            set{_time = value;}
        }
    }
}