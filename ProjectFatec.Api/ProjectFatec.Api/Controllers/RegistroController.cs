using Fatec.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ProjectFatec.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<RegistroEntity>()
            {
                new RegistroEntity
                {
                    Id = 1,
                    Nome = "Rafael",
                    SobreNome = "Augusto",
                    DataNascimento = new DateTime(1980, 01, 01),
                    Email = "rafaaugustocontato@gmail.com",
                    Senha = "2384349i39vmsidfvmsi@"
                },
                new RegistroEntity{
                    Id = 2,
                    Nome = "Joao",
                    SobreNome = "Augusto",
                    DataNascimento = new DateTime(1990, 01, 01),
                    Email = "joaozinhooo@gmail.com",
                    Senha = "fiosdnmaipfmsip@Rfsdf"
                }
            }); 
        }
    }
}
