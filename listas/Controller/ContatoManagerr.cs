using listas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas.Controller
{
    public interface IContatoManager
    {
        // Princípio da Segregação de Interface (ISP): 
        // Define uma interface pequena e específica que será implementada pelo Gerenciador.
        void AdicionarContato(Contato contato);
        void AtualizarContato(Contato contato);
        void DeletarContato(Contato contato);
        List<Contato> MostrarTodos();
        Contato AcharContato(int telefone);
    }
}
