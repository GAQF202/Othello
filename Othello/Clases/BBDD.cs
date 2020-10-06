using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Othello.Models;

namespace Othello.Clases
{
    public class BBDD
    {
        DataBase db = new DataBase();
        public void registro(string nombreUsuario, string nombre, string apellido, string nacimiento, string pais, string contraseña)
        {
            //Creo una instancia de la tabla Usuario de la db
            Usuario us = new Usuario();
            us.Usuario1 = nombreUsuario;
            us.Nombre = nombre;
            us.Apellido = apellido;
            us.Nacimiento = nacimiento;
            us.Pais = pais;
            us.Contraseña = contraseña;
            //if (nombreUsuario!="" && nombre != "" && apellido != "" && nacimiento != "" && pais != "" && contraseña!= "")
            if (us.Usuario1 != null && us.Nombre != null && us.Apellido != null && us.Nacimiento != null && us.Pais != null && us.Contraseña != null && nombreUsuario != "" && nombre != "" && apellido != "" && nacimiento != "" && pais != "" && contraseña != "")
            {
                db.Usuario.Add(us);
                db.SaveChanges();
            }
        }

        public bool existe(string nombreUsuario, string contraseña, out int idUsuario)
        {
            idUsuario = (from u in db.Usuario where u.Usuario1 == nombreUsuario && u.Contraseña == contraseña select u.IdUsuario).FirstOrDefault();

            if (idUsuario != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class verificador 
    {
        DataBase db = new DataBase();
        public bool existe(string nombreUsuario, string contraseña, out int idUsuario)
        {
            idUsuario = (from u in db.Usuario where u.Usuario1 == nombreUsuario && u.Contraseña == contraseña select u.IdUsuario).FirstOrDefault();

            if (idUsuario != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}