using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurguerApp.WebAPI.Models
{
    public class Produto
    {
        public Produto() { }
        
        public Produto(int id, 
                    string descricao,
                    DateTime dataCadastro,
                    string url,
                    int configuracaoId
                    ) 
        {
            this.Id = id;
            this.Descricao = descricao;
            this.DataCadastro = dataCadastro;
            this.Url = url;
            this.ConfiguracaoId = configuracaoId;
   
        }
        public int Id { get; set; }    
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Url { get; set; }
        public int ConfiguracaoId { get; set; }

    }
}