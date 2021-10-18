using Cafeine_DinDin_Backend.Utils;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cafeine_DinDin_Backend.Entities
{
    public class User
    {
        public String Name { get; set; }
        public String Login { get; set; }
        public Char Level { get; set; }
        [NotMapped] 
        public String Salt { get; set; }
        [NotMapped] 
        public String HashSenha { get; set; }

        public User(string name, string login, char level)
        {
            this.Name = name;
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
