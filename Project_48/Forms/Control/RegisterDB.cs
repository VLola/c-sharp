using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_48.Forms.Control
{
    public class RegisterDB
    {
        public void Registration(string email, string pass)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Users; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                User reg = new User(email, new Crypt().Generate(pass));
                connection.Insert(reg);
            }
        }
    }
}
