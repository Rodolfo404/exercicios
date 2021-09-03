using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            return View(listUsuarios);
        }
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(Usuario model)
        {
            list
        }
    }
}