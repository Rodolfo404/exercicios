using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        static SkateRepository repository = new SkateRepository();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cadastro()
        {

            return View();
        }

        public ActionResult Tabela()
        
        {
            List<Skate> model = repository.Read();
            return View(model);
                      
        }


        [HttpPost]
        public ActionResult Salvar(Skate model)
        {
            repository.Salvar(model);
            return View();
        }

        public ActionResult Deletar(int id)
        {
            repository.Delete(id);
            return RedirectToAction("Tabela");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            Skate model = repository.Read(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Editar(Skate model)
        {
            repository.Editar(model);
            return RedirectToAction("Tabela");
        }
    }
}