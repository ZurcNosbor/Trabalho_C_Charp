//CRIAÇÃO CONTROLLER PARA CÁLCULO PITAGORAS

using Microsoft.AspNetCore.Mvc;

namespace Ex04Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PitagorasController : ControllerBase
    {
        private readonly ILogger<PitagorasController> _logger;

        public PitagorasController(ILogger<PitagorasController> logger)
        {
            _logger = logger;
        }

        //DEFINE UM PONTO HTTP POST PARA REALIZAR O CALCULO
        [HttpPost]

        //USADA CLASSE contentResult PARA RETORNAR CONTEÚDO DE TEXTO SIMPLES OU HTML NA RESPOSTA HTTP
        public  ContentResult Post(string ruAluno)
        {

            //FAZ O CALCULO DOS QUADRADOS DOS 3 PRIMEIROS DIGITOS DO RU
            var a = Math.Pow(int.Parse(ruAluno.ElementAt(0).ToString()), 2);
            var b = Math.Pow(int.Parse(ruAluno.ElementAt(1).ToString()), 2);
            var c = Math.Pow(int.Parse(ruAluno.ElementAt(2).ToString()), 2);

            //FAZ O CALCULO DE a * a + b * b
            var resultadoPitagora = a + b;

            //DEFINE A STRING PADRÃO PARA RESPOSTA
            var retornoPitagora = "NÃO É UM TRIANGULO PITAGORICO!!!\n";

            //VERIFICA SE SATISFAZ A CONDIÇÃO DO TEOREMA DE PITÁGORAS
            if (c == (a + b))
                {
                    retornoPitagora = "É UM TRIANGULO PITAGORICO\n";
                }

            //MONTA A MENSAGENS COM AS INFORMÇÕES DAS RESPOSTAS
            retornoPitagora += $"CÁLCULO DE PITAGORAS COM OS 3 PRIMEIROS DIGITOS DO RU:\n" +
                               $"a²: {a},\nb²: {b}, \nc²: {c}.\n" +
                               $"RESULTADO DE {a} + {b} É: {resultadoPitagora}";

            //RETORNA A RESPOSTA COMO TEXTO SIMPLES
            return Content(retornoPitagora, "text/plain");
        }
    }
}
