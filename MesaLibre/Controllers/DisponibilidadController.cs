using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MesaLibre.Controllers
{
    public class DisponibilidadController : Controller
    {
        // GET: Disponibilidad
        public ActionResult AsignarDisponibilidad()
        {
            return View();
        }

        #region BuscarDiponibiildad

        public ActionResult BuscarDisponibilidad()
        {
            return View();
        }

        public ActionResult BuscarDisponibilidadPorRestuarante()
        {
            return View("_ListaDisponibilidad");
        }

        public ActionResult BuscarDisponibilidadPorRestuaranteTipoMenu()
        {
            return View("_ListaDisponibilidad");
        }

        public ActionResult BuscarDisponibilidadReal()
        {
            return View();
        }

        public ActionResult BuscarDisponibilidadRealPorRestuarante()
        {
            return View("_ListaDisponibilidadReal");
        }

        public ActionResult BuscarDisponibilidadRealPorRestuaranteTipoMenu()
        {
            return View("_ListaDisponibilidadReal");
        }


        #endregion BuscarDiponibiildad

    }//class
}
