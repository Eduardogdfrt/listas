using System;
using listas.View;
class Program
{
    static void Main(string[] args)
    {
        Interfacee i = new Interfacee();
        Console.WriteLine("Bem-vindo ao Gerenciador de Contatos!");

       

        while (true)
        {
            ExibirMenu();
            string opcao = Console.ReadLine().Trim();

            switch (opcao)
            {
                case "1":
                    i.CriarContato();
                    break;
                case "2":
                    i.DeletarContato();
                    break;
                case "3":
                    i.RetornarLista();
                    break;
                case "4":
                    i.AtualizarContato();
                    break;
                case "5":
                    i.RetornarPessoa();
                    break;
                case "6":
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void ExibirMenu()
    {
        Console.WriteLine("\nEscolha uma opção:");
        Console.WriteLine("1. Criar um contato");
        Console.WriteLine("2. Deletar um contato");
        Console.WriteLine("3. Listar todos os contatos");
        Console.WriteLine("4. Atualizar Contatos");
        Console.WriteLine("5. Retornar Pessoa");
        Console.WriteLine("6. Sair");
    }
}
