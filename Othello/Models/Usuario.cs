using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Othello.Models
{
    public class Usuario
    {
        public Usuario()
        {
        }

        public String username { get; set; }
        public String nombre { get; set; }
        public String lastname { get; set; }
        public String date { get; set; }
        public String country { get; set; }
        public String password { get; set; }
    }
}