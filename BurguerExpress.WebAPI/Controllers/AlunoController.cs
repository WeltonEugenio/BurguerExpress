using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace BurguerApp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public AlunoController() { } 
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("ola genate");
        }

        
        
        
        
        

        
    }
}