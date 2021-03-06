﻿using math_games.Models;
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

        
        public ActionResult IniciarSesion()
        {
            return View();
        }

        public ActionResult CrearCuenta()
        {
            return View();
        }

        public ActionResult Elegirprofesor()
        {
            return View();
        }

        public ActionResult Pregunta()
        {
            return View();
        }




        public ActionResult IniciarRegistro(string Tipo, string Nombre, string DNI, string Edad, string Mail, string Password)
        {
            Usuario User = new Usuario();
            User.Tipo = Tipo;
            User.Nombre = Nombre;
            User.DNI = DNI;
            User.Edad = Edad;
            User.Mail = Mail;
            User.Contraseña = Password;

            if(User.Tipo == "Alumno"){
                return View("~/Views/Home/usuarioalumno.cshtml");
            }
            else
            {
                return View("~/Views/Home/usuariodocente.cshtml");
            }
                       

        }

        public ActionResult IniciarLogueo(string Tipo)
        {
            Usuario UserLogueado = new Usuario();
            UserLogueado.Tipo = (string)Tipo;


            if (UserLogueado.Tipo == "Alumno")
            {
                return View("~/Views/Home/usuarioalumno.cshtml");
            }
            else
            {
                return View("~/Views/Home/usuariodocente.cshtml");
            }
            

        }

    }
}