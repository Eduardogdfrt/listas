using listas.Observer;
using System;
using System.Collections.Generic;
namespace listas.Observer
{
    public class Subject
    {
        private List<IObserver> observers = new List<IObserver>();
        private int _state;

        public int State
        {
            get { return _state; }
            set
            {
                _state = value;
                NotifyObservers();
            }
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(_state);
            }
        }
    }



}
