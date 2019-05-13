using System;

namespace Capitulo9_composition2.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

        public Client()
        {
        }
        public Client(string nome)
        {
            Name = nome;
        }

        public Client(string nome, string email)
        {
            Name = nome;
            Email = email;
        }
        public Client(string nome, string email, DateTime birthday)
        {
            Name = nome;
            Email = email;
            Birthday = birthday;
        }
    }
}
