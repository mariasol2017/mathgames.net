using math_games.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace math_games.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult IniciarSesion()
        {
            return View();
        }

        public ActionResult CrearCuenta()
        {
            return View();
        }

        public ActionResult registrar(string Tipo, string Nombre, string DNI, string Edad, string Mail, string Contraseña)
        {
            Usuario User = new Usuario();
            User.Tipo = Tipo;
            User.Nombre = Nombre;
            User.DNI = DNI;
            User.Edad = Edad;
            User.Mail = Mail;
            User.Contraseña = Contraseña;

            if(Tipo == "alumno"){
                return View("~/Views/Home/usuarioalumno.cshtml");
            }
            else
            {
                return View("~/Views/Home/usuariodocente.cshtml");
            }
        }

 
    }
}