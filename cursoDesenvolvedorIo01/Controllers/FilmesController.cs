using cursoDesenvolvedorIo01.Models;
using Microsoft.AspNetCore.Mvc;

namespace cursoDesenvolvedorIo01.ViewComponents
{
    public class FilmesController : Controller
    {
        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Adicionar(Filme filme)
        {
            if (ModelState.IsValid)
            {

            }
            return View(filme);
        }
    }
}
