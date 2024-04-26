using listas.Controller;
using listas.Model;
using listas.View;
using listas.Observer;
namespace listas.Controller
{
    public class Gerenciador : IContatoManager
    {
        private List<IObserver> observers = new List<IObserver>();
        private List<Contato> ContatoList { get; set; } = new List<Contato>();

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
                observer.Update(ContatoList.Count);
            }
        }

        public void AdicionarContato(Contato contato)
        {
            ContatoList.Add(contato);
        }

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

