using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BurguerApp.WebAPI.Models;

namespace BurguerApp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class ProdutoController : ControllerBase
    {
        public List<Produto> Produtos = new List<Produto>(){
            new Produto(){
                Id = 1,
                Descricao = "descricao",
                DataCadastro = Convert.ToDateTime("01/01/2001"),
                Url = "url",
                ConfiguracaoId = 1
            },
            new Produto(){
                Id = 2,
                Descricao = "descricao27",
                DataCadastro = Convert.ToDateTime("01/01/2002"),
                Url = "url2",
                ConfiguracaoId = 1
            },
        };
         
        public ProdutoController() { } 


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Produtos) ; 
        }

       
        [HttpGet("ById")]
        public IActionResult GetById(int id)
        {
            var prod = Produtos.FirstOrDefault(p => p.Id == id);
            if (prod == null) return BadRequest("Não encontrado");

            return Ok(prod) ; 
        }
       
       
        [HttpGet("ByName")]
        public IActionResult GetByName(string name)
        {
            var prod = Produtos.FirstOrDefault(p => p.Descricao.Contains(name,StringComparison.OrdinalIgnoreCase));
            if (prod == null) return BadRequest("Não encontrado");

            return Ok(prod) ; 
        }
        
        
        [HttpPost]
        public IActionResult Post(Produto produto)
        {
            return Ok(produto) ; 
        }

       
        [HttpPut("{id}")]
        public IActionResult Put(int id, Produto produto)
        {
            return Ok(produto) ; 
        }
       
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Produto produto)
        {
            return Ok(produto) ; 
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Produto removido com sucesso! ") ; 
        }
        
    } 

}