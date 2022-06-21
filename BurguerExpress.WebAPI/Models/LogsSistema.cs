using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurguerApp.WebAPI.Models
{
 
    public class LogsSistema
    {
        public LogsSistema()  {  }
    
        public LogsSistema(int id,
                        string descricao, 
                        int usuarioID,
                        DateTime dataCadastro) 
        {
            this.Id = id;
            this.Descricao = descricao;
            this.UsuarioID = usuarioID;
            this.DataCadastro = dataCadastro;
   
        }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int UsuarioID { get; set; }
        public DateTime DataCadastro { get; set; }
        public Usuario Usuario { get; set; }
    }
}