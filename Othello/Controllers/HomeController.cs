using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Othello.Clases;
using System.Web.Mvc;


namespace Othello.Controllers
{
    public class HomeController : Controller
    {
        BBDD datos = new BBDD();
        
        // GET: Home
        public ActionResult Index(string nombreUsuario, string nombre, string apellido, string nacimiento, string pais, string contraseña)
        {
            verificador da = new verificador();
            int idUsuario = 0;
            bool existe = da.existe(nombreUsuario, contraseña, out idUsuario);
            if (!existe)
            {
                datos.registro(nombreUsuario, nombre, apellido, nacimiento, pais, contraseña);
                return View();
            }
            else
            {
                return Redirect("/Home/Partida");
            }
                

        }

        public ActionResult Partida() 
        {
            return View();
        }
        public ActionResult Ingreso()
        {
            return View();
        }
       /*public ActionResult Login(string nombreUsuario, string contraseña) 
        {
            int idUsuario = 0;
            bool existe = datos.existe(nombreUsuario,contraseña,out idUsuario);
            if (existe)
            {
                return Redirect("/Home/Partida");
            }
            else 
            { 
                return Redirect("/Home/Index");
            }
        }*/
    }
}