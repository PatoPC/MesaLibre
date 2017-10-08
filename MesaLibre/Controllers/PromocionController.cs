using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MesaLibre.Controllers
{
    public class PromocionController : Controller
    {
        // GET: Promocion
        public ActionResult CrearPromocion()
        {
            return View();
        }

#region buscarPrmociones
        public ActionResult BuscarPromocion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BuscarPromocionesPorCodigo()
        {
            return View("_ListaPromociones", "");
        }
        [HttpPost]
        public ActionResult buscarPromocionPorFechaCreacion()
        {
            return View("_ListaPromociones", "");
        }
        #endregion
        [HttpPost]
        public JsonResult generarCodigoPromocion()
        {
            string codigoPromocion = "";
            string identificador = Guid.NewGuid().ToString().Replace("-", string.Empty);

            codigoPromocion = DateTime.Now.ToString("ddMMyy")+identificador.Substring(2,3);

            return Json(codigoPromocion,JsonRequestBehavior.AllowGet);
        }

        }//class
}