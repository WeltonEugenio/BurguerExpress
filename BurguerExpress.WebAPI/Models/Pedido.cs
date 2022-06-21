using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurguerApp.WebAPI.Models
{
       
    public class Pedido
    {
        
        public Pedido() { }

        
        public Pedido(int id, 
                    int clienteId,
                    int configuracaoId,
                    DateTime dataPedido,
                    float valorEntrega,
                    float subTotal, 
                    float total, 
                    float descontoPedido,
                    ENUM_SITUACAO_PEDIDO status) 
        {
            this.Id = id;
            this.ClienteId = clienteId;
            this.ConfiguracaoId = configuracaoId;
            this.DataPedido = dataPedido;
            this.ValorEntrega = valorEntrega;
            this.SubTotal = subTotal;
            this.Total = total;
            this.DescontoPedido = descontoPedido;
            this.Status = status;
   
        }
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int ConfiguracaoId { get; set; }
        public DateTime DataPedido { get; set; }
        public float ValorEntrega { get; set; }
        public float SubTotal { get; set; }
        public float Total { get; set; }
        public float DescontoPedido { get; set; }
        public ENUM_SITUACAO_PEDIDO Status { get; set; }
        public Cliente Cliente { get; set; }

    }
}