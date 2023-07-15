using System;

namespace CadastroClientes
{
    class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public Cliente(string nome, int idade, string email)
        {
            Nome = nome;
            Idade = idade;
            Email = email;
        }
    }
}
