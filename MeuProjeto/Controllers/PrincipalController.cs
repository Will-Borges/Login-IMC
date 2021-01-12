using MeuProjeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeuProjeto.Controllers
{
    public class PrincipalController : Controller
    {
        // GET: PaginaInicial
        public ActionResult Inicio()
        { 
            return View(new CalculoIMC());
        }

        [HttpPost]
        public ActionResult Inicio(CalculoIMC calculoIMC)
        {
            return View(calculoIMC);
        }

    }
}