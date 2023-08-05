//CRIAÇÃO CONTROLLER DADOS DO ALUNO

using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Ex04Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DadosAlunoController : ControllerBase
    {
        private readonly ILogger<DadosAlunoController> _logger;

        public DadosAlunoController(ILogger<DadosAlunoController> logger)
        {
            _logger = logger;
        }

        //RETORNARA OS DADOS DO ALUNO
        [HttpGet]
        public String Get()
        {
            //CRIAÇÃO DO OBJETO ALUNO COM AS INFORMÇAOES
            var aluno = new Aluno
            {
                Nome = "Robson Cruz de Melo",
                RU = "3773638"
            };

            //SERIALIZA OD DADOS EM JSON
            return JsonSerializer.Serialize(aluno);
        }
    }
}

