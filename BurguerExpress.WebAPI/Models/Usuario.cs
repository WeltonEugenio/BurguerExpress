using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurguerApp.WebAPI.Models
{
    public class Usuario
    {
        public Usuario(){}
        
        public Usuario(int id,
                    string login, 
                    string senha,
                    int configuracaoId, 
                    DateTime dataCadastro,
                    DateTime dataUltimoAcesso, 
                    ENUM_SITUACAO_USUARIO status) 
        {
            this.Id = id;
            this.Login = login;
            this.Senha = senha;
            this.ConfiguracaoId = configuracaoId;
            this.DataCadastro = dataCadastro;
            this.DataUltimoAcesso = dataUltimoAcesso;
            this.Status = status;
   
        }
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int ConfiguracaoId { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataUltimoAcesso { get; set; }
        public ENUM_SITUACAO_USUARIO Status { get; set; }
    }
}