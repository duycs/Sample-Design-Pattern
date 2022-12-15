using System.Collections.Generic;
using System;

namespace SampleDesignPattern.ObserverPattern
{
    abstract class Subject
    {
        List<Observer> observers = new List<Observer>();

        public void Attach(Observer observer){
            observers.Add(observer);
        }

        public void Deattach(Observer observer){
            observers.Remove(observer);
        }

        public void Notify(){
            foreach(var observer in observers){
                observer.Update();
            }
        }
    }
}