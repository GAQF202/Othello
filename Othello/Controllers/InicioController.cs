using Othello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Othello.Controllers
{
    public class InicioController : Controller
    {
        // GET: Inicio
        public ActionResult Usuario()
        {
            Usuario user = new Usuario(); 
            user.username = Request.Form["username"];
            user.nombre = Request.Form["name"];
            user.lastname = Request.Form["lastname"];
            user.date = Convert.ToString(Request.Form["date"]);
            user.country = Request.Form["country"];
            user.password = Convert.ToString(Request.Form["password"]);
            return View(user);
        }

        public ActionResult Index() 
        {
            return View();
        }
            
    }
}