using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurguerApp.WebAPI.Models
{
    public class CategoriaProdutoValor
    {
        public CategoriaProdutoValor(){}

        public CategoriaProdutoValor(int produtoId,
                                    int categoriaId,
                                    float valorProduto) 
        {
            this.ProdutoId = produtoId;
            this.CategoriaId = categoriaId;
            this.ValorProduto = valorProduto;
   
        }
        public int ProdutoId { get; set; }
        public int CategoriaId { get; set; }
        public float ValorProduto{ get; set; }
        public Produto Produto { get; set; }
        public Categoria Categoria { get; set; }

    }
}