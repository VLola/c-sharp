using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_48.Forms.Control
{
    public class Crypt
    {
        public string Generate(string pass)
        {
            return BCrypt.Net.BCrypt.HashPassword("Pass");
        }
    }
}
