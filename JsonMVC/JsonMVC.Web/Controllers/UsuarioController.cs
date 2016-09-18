using System.Web.Mvc;
using JsonMVC.Web.Models;

namespace JsonMVC.Web.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Index()
        {
            var model = new UsuarioViewModel
            {
                Id = 1,
                Nome = "Luciano Carlos de Jesus",
                Email = "lucianocjesus@gmail.com",
                Telefone = "(19) 98206-6377",
                Celular = "(19) 98206-6377",
                DocumentoRg = "321907760",
                DocumentoCpf = "28156649842",
                Facebook = "lucianocjesus",
                Twitter = "@lucianocjesus",
                Instagram = "lucianocjesus"
            };
            return View(model);
        }
    }
}