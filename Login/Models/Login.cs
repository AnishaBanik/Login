﻿using System.ComponentModel.DataAnnotations;

namespace Login.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
