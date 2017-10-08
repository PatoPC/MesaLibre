using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MesaLibre.Controllers
{
    public class TipoComidaController : Controller
    {
        // GET: TipoComida
        public ActionResult CrearTipoComida()
        {
            return View();
        }

        public ActionResult _ListaTipoComida()
        {
            return View();
        }
    }
}