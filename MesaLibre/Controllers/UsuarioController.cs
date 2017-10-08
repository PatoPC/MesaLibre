using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MesaLibre.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult CambiarContrasena()
        {
            return View();
        }

        public ActionResult CrearUsuario()
        {
            return View();
        }

        #region Busqueda Usuarios
        public ActionResult BuscarUsuario()
        {
            return View();
        }

        public ActionResult BuscarTodosUsuarios()
        {
            return View("_ListaUsuarios", "");
        }

        public ActionResult BuscarUsuarioPorIdentificacion(string identificacionUsuario)
        {

            return View("_ListaUsuarios", "");
        }


        #endregion
        public ActionResult CerrarSesion()
        {
            return RedirectToAction("Index","Home");
        }

    }
}