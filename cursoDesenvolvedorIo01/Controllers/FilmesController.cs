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
    }
}
