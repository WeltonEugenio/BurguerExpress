using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurguerApp.WebAPI.Models
{
    public class Cliente
    {
        public Cliente(){ }
        
        public Cliente(int id, 
                    string nome, 
                    string endereco, 
                    string contato, 
                    DateTime dataCadastro) 
        {
            this.Id = id;
            this.Nome = nome;
            this.Endereco = endereco;
            this.Contato = contato;
            this.DataCadastro = dataCadastro;
   
        }
        public int Id { get; set; }   
        public string Nome { get; set; } 
        public string Endereco { get; set; }
        public string Contato { get; set; }
        public DateTime DataCadastro { get; set; }
        
    }
}