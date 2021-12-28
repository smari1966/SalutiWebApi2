using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/saluti")]
    public class SalutiController : Controller
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult TestConnex()
        {
            return Ok(new InfoMsg(DateTime.Today, $"Saluti sono la tua prima web api in Azure App Services"));
        }

        [HttpGet("{Nome}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<InfoMsg> getSaluti2(string Nome)  
        {
            return Ok(new InfoMsg(DateTime.Today, $"Saluti {Nome}, sono la tua web api aggiornata in Azure App Services"));
        }
		
		[ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet("{Nome}/{version}")]
        public ActionResult<InfoMsg>getSaluti3(string Nome, string version)
        {
            //test
            return Ok(new InfoMsg(DateTime.Today, $"Saluti {Nome}, sono la versione {version} della web api aggiornata con GitHub"));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet("{Nome}/{version}/{message}")]
        public ActionResult<InfoMsg> getSaluti4(string Nome, string version, string message)
        {
            //test
            return Ok(new InfoMsg(DateTime.Today, $"Saluti {Nome}, sono la versione {version} della web api aggiornata con GitHub da {message}"));
        }
    }
}