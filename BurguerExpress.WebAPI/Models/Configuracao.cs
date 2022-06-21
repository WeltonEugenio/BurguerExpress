using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurguerApp.WebAPI.Models
{
    public class Configuracao
    {
       public Configuracao(){ }

        public Configuracao(int id,
                        string empresa, 
                        string nomeFantasia,
                        float taxaEntrega, 
                        float taxaOperacional, 
                        DateTime dataCadastro,
                        DateTime dataVencimento, 
                        char status,
                        string contato) 
        {
            this.Id = id;
            this.Empresa = empresa;
            this.NomeFantasia = nomeFantasia;
            this.TaxaEntrega = taxaEntrega;
            this.TaxaOperacional = taxaOperacional;
            this.DataCadastro = dataCadastro;
            this.DataVencimento = dataVencimento;
            this.Status = status;
            this.Contato = contato;
   
        }
        public int Id { get; set; }
        public string Empresa { get; set; }
        public string NomeFantasia { get; set; }
        public float TaxaEntrega { get; set; }
        public float TaxaOperacional { get; set; }
        public DateTime  DataCadastro { get; set; }
        public DateTime  DataVencimento { get; set; }
        public char Status { get; set; }
        public string Contato { get; set; }
    }
}