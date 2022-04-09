using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_48.Forms.Control
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User(string Email, string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }
    }
}
