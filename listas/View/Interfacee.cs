using System;
using System.Collections.Generic;
using listas.Model;
using listas.Observer;
using listas.Controller;
namespace listas.View
{
    public class Interfacee : IObserver
    {
        public static Gerenciador g = new Gerenciador();

  

        public void Update(int newState)
        {
            Console.WriteLine($"State has changed to: {newState}");
        }

        public void RetornarLista()
        {
            Console.WriteLine("Segue todos os usuários:");
            var contatos = g.MostrarTodos();
            foreach (var contato in contatos)
            {
                Console.WriteLine($"Nome: {contato.Nome}, Email: {contato.Email}, Telefone: {contato.Telefone}");
            }
        }

        public void AtualizarContato()
        {
            Console.Write("Digite o telefone do contato a ser atualizado: ");
            int telefone = int.Parse(Console.ReadLine());
            g.AtualizarContato(g.AcharContato(telefone));
        }

        public void RetornarPessoa()
        {
            Console.Write("Digite o nome do contato: ");
            int telefone = int.Parse(Console.ReadLine());
            var cont = g.AcharContato(telefone);
            Console.WriteLine($"Nome: {cont.Nome}, Email: {cont.Email}, Telefone: {cont.Telefone}");
        }

        public void CriarContato()
        {
            Console.Write("Digite o nome do contato: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o email do contato: ");
            string email = Console.ReadLine();

            Console.Write("Digite o telefone do contato: ");
            int telefone = int.Parse(Console.ReadLine());

            Contato c = new Contato(nome, email, telefone);
            Console.WriteLine($"Contato {nome} criado.");
            g.AdicionarContato(c);
        }

        public void DeletarContato()
        {
            Console.Write("Digite o Telefone do contato a ser deletado: ");
            int telefone = int.Parse(Console.ReadLine());
            g.DeletarContato(g.AcharContato(telefone));
        }
    }
}