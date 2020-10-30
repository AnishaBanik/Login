using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class Users : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
