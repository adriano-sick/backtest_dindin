using Cafeine_DinDin_Backend.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeine_DinDin_Backend.Entities
{
    public class User

    {
        public String name { get; set; }
        public String Login { get; set; }
        public Char Level { get; set; }
        [NotMapped] 
        public String Salt { get; set; }
        [NotMapped] 
        public String HashSenha { get; set; }

        public User(string name, string login, char level)
        {
            this.name = name;
            Login = login;
            Level = level;
           
        }
        public String CreateSalt()
        {
            Salt = Conversor.RandomString(10);
            return Salt;
        }
    }
}
