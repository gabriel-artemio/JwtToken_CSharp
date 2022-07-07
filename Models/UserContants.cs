using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwt.Models
{
    public class UserContants
    {
        public static List<User> Usuarios = new List<User>()
        {
            new User() {Nome = "Gabriel", Usuario = "Gabriel", Senha = "1234"}
        };
    }
}
