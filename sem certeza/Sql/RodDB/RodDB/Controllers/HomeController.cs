using RodDB.Models;
using RodDB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RodDB.Controllers
{
    public class HomeController : Controller
    {
        MotoRepository repository = new MotoRepository();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Moto model)
        {
            
            repository.Create(model);
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ActionResult Editar(int id)
        {
            
            return View(repository.Read(id));
        }
        [HttpPost]
        public ActionResult Editar(Moto model)
        {
            
            repository.Update(model);
            return RedirectToAction("Listar");
        }
        public ActionResult Listar()
        {
           
            return View(repository.Read());

        }
        public ActionResult Deletar(int id)
        {
            
            repository.Delete(id);
            return RedirectToAction("Listar");
        }
        public ActionResult Detalhes(int id)
        {
            
            return View(repository.Read(id));

        }
    }
}