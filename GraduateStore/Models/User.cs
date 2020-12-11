using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace GraduateStore.Models
{
    public class User : IdentityUser
    {
        private string Password { get; set; }

        public User(string password)
        {
            Password = password;
        }

    }
}
