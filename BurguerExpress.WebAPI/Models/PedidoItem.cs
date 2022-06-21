using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurguerApp.WebAPI.Models
{
    public class PedidoItem
    {
        public PedidoItem() { }
        
        
        public PedidoItem(int id,
                        int pedidoId, 
                        int produtoId,
                        float quantidade, 
                        float valorUnitario,
                        float desconto, 
                        float valorTotal) 
        {
            this.Id = id;
            this.PedidoId = PedidoId;
            this.ProdutoId = produtoId;
            this.Quantidade = quantidade;
            this.ValorUnitario = valorUnitario;
            this.Desconto = desconto;
            this.ValorTotal = valorTotal;
   
        }
        
        public int Id { get; set; }
        public int PedidoId { get; set; } 
        public int ProdutoId { get; set; }  
        public float Quantidade { get; set; } 
        public float ValorUnitario { get; set; }
        public float Desconto { get; set; }
        public float ValorTotal { get; set; }
        public Produto Produto { get; set; }
    }
}