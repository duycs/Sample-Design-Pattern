namespace SampleDesignPattern.ObserverPattern{
    class ConcreteSubject : Subject{
        public string subjectState;
        public string SubjectStatate{
            get {return subjectState;}
            set {subjectState = value;}
        }
    }
}