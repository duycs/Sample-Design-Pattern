namespace Sample_Design_Pattern.ObserverPattern{
    class ConcreteSubject : Subject{
        public string subjectState;
        public string SubjectStatate{
            get {return subjectState;}
            set {subjectState = value;}
        }
    }
}