using listas.Controller;
using listas.Model;
using listas.View;
using listas.Observer;
namespace listas.Controller
{
    public class Gerenciador : IContatoManager
    {
        // Princípio da Inversão de Dependência (DIP): 
        // Gerenciador depende de uma abstração (IObserver) e não de uma concretização.
        private List<IObserver> observers = new List<IObserver>();
        private List<Contato> ContatoList { get; set; } = new List<Contato>();

        // Princípio Aberto-Fechado (OCP): 
        // Métodos para adicionar e remover observadores permitem a extensão sem modificação.
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        // Princípio da Responsabilidade Única (SRP): 
        // Gerenciador tem a responsabilidade de notificar os observadores.
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(ContatoList.Count);
            }
        }

        // Princípio de Substituição de Liskov (LSP): 
        // Métodos que implementam a interface IContatoManager.
        public void AdicionarContato(Contato contato)
        {
            ContatoList.Add(contato);
            NotifyObservers();
        }

        // ... rest of your methods ...
        public void AtualizarContato(Contato novoContato)
        {
            var existingContact = ContatoList.Find(c => c.Telefone == novoContato.Telefone);

            if (existingContact != null)
            {
                Console.WriteLine("digite o  novo nome");
                var nome = Console.ReadLine();
                Console.WriteLine("digite o  novo email");
                var email = Console.ReadLine();

                existingContact.Nome = nome;
                existingContact.Email = email;
            }
        }

        public void DeletarContato(Contato contato)
        {
            ContatoList.Remove(contato);
        }

        public List<Contato> MostrarTodos()
        {
            return ContatoList;
        }

        public Contato AcharContato(int telefone)
        {
            var existingContact = ContatoList.Find(c => c.Telefone == telefone);
            return existingContact;
        }


    }
}

