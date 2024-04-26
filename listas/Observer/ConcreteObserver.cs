using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas.Observer
{
    public class ConcreteObserver : IObserver
    {
        private string _name;

        public ConcreteObserver(string name)
        {
            _name = name;
        }

        public void Update(int newState)
        {
            Console.WriteLine($"Observer {_name} is notified with new state: {newState}");
        }
    }
}
