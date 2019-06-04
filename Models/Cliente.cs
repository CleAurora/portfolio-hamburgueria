using System;

namespace Hamburgueria.Models
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string Endereco {get;set;}
        public string Telefone {get;set;}
        public string Email {get;set;}
        public string Senha{get;set;}
        public int Id {get; set;}
        public DateTime DataNascimento {get;set;}
    }
}