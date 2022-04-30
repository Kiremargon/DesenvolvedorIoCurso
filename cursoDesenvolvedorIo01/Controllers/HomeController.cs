using cursoDesenvolvedorIo01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace cursoDesenvolvedorIo01.Controllers
{

    [Route("")]
    [Route("gestao-cliente")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("")]
        [Route("pagina-inicial")]
        [Route("pagina-inicial/{id:int}/{categoria:guid}")]
        public IActionResult Index(int id, Guid categoria)
        {
            /*Declaração manual da model
            var filme = new Filme
            {
                Titulo = "Oi",
                DataLancamento = DateTime.Now,
                Genero = null,
                Avaliacao = 10,
                Valor = 20000
            };

            return RedirectToAction("Privacy", filme);
            */
            return View();
        }

        [Route("privacidade")]
        [Route("politica-de-privacidade")]
        public IActionResult Privacy(/*Filme filme*/)
        {
            /*Validação de Model pelo DotNet
            if(ModelState.IsValid)
            {   
            }

            foreach (var errosList in ModelState.Values.SelectMany(m => m.Errors)) 
            {
                Console.WriteLine(errosList.ErrorMessage);
            }
            */

            return View();
            //var fileBytes = System.IO.File.ReadAllBytes(@"G:\Imagens\giphy.gif");
            //var fileName = "Draguinho.gif";
            //return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro-econtrado")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}