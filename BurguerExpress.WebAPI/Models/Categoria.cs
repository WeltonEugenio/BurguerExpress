using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurguerApp.WebAPI.Models
{

    public class Categoria
    {
        public Categoria(){}

        public Categoria(int id, 
                        string descricao,
                        int configuracaoId,
                        ENUM_DIAS_SEMANA diaSemana ) 
        {
            this.Id = id;
            this.Descricao = descricao;
            this.ConfiguracaoId = configuracaoId;
            this.DiaSemana = diaSemana;
   
        }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int ConfiguracaoId { get; set; }
        public ENUM_DIAS_SEMANA DiaSemana { get; set; }
        public IEnumerable<CategoriaProdutoValor> CategoriaProdutoValor { get; set; }

    }
}