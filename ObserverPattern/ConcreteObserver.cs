using System;

namespace Sample_Design_Pattern.ObserverPattern
{
    class ConcreteObserver : Observer
    {
        private string _name;
        private string _observerState;
        private ConcreteSubject _subject;

        public ConcreteObserver(ConcreteSubject subject, string name){
            _subject = subject;
            _name = name;
        }

        public override void Update()
        {
            _observerState = _subject.SubjectStatate;
            Console.WriteLine("Observer {0} have new state is {1}", _name, _observerState);
        }

        public ConcreteSubject Subject{
            get{return _subject;}
            set{_subject = value;}
        }
    }
}