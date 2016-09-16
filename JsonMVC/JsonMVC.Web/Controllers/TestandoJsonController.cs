using System.Collections.Generic;
using System.Web.Mvc;

namespace JsonMVC.Web.Controllers
{
    public class TestandoJsonController : Controller
    {
        // GET: TestandoJson
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetDados()
        {
            var resultado = new List<object>();
            
            resultado.Add(new
            {
                nome = "Luciano Carlos de Jesus",
                telefone = "19982066377"
            });

            resultado.Add(new
            {
                nome = "Simone Maria Malaquias",
                telefone = "19991924904"
            });

            resultado.Add(new
            {
                nome = "Jordã Carlos de Jesus",
                telefone = "19999525160"
            });

            return Json(resultado, JsonRequestBehavior.AllowGet);
        }
    }
}