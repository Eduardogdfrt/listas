using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas.Observer
{
    // IObserver.cs
    public interface IObserver
    {
        // Princípio da Segregação de Interface (ISP): 
        // Define uma interface pequena e específica que será implementada pelos observadores.
        void Update(int newState);
    }

}
