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

        public ActionResult Tabela()
        
        {
            List<Skate> model = repository.Tabela();
            return View(model);
                      
        }

        public ActionResult Cadastro()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Salvar(Skate model)
        {
            repository.Salvar(model);
            return View();
        }
    }
}