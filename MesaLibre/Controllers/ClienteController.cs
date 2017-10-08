using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MesaLibre.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Comensal
        public ActionResult CrearCliente()
        {
            return View();
        }
        #region Busqueda Cliente
        public ActionResult BuscarCliente()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BuscarClientePorIdentificacion(string numeroIdentificacionComensal)
        {

            return View("_ListaCliente", "");
        }

        [HttpPost]
        public ActionResult buscarClientePorCorreo(string correoComensal)
        {

            return View("_ListaCliente", "");
        }

        [HttpPost]
        public ActionResult buscarClientePorLocal(string correoComensal, string nombreLocal)
        {

            return View("_ListaCliente", "");
        }
        #endregion Busqueda Clientes
    }
}