using System;

namespace listas.Model
{
    public class Contato
    {

        public string Nome { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }

        public Contato(string nome, string email, int telefone)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }
    }
}