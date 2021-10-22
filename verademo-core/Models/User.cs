using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace verademo_core.Models
{
    public class User
    {
        private string username;
        private string password;

        private string birthdate;

        public User(string username)
        {
            this.username = username;
        }

        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
    }
}
