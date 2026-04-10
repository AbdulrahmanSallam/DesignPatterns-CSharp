using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_CSharp.Behavioral.Observer
{

    // Observable 
    public abstract class Subject : ISubject
    {
        private readonly List<IObserver> observers = [];
       
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        // push style 
        //public void NotifyObservers(int value)
        //{
        //    foreach (var observer in observers)
        //    {
        //        observer.Update(value);
        //    }
        //}


        // pull style 
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                // push style 
                observer.Update();
            }
        }

    }

}
