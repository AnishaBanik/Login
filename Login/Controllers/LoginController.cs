using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Login.Data;
using Login.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Login.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;
        //private StudentContext _context = new StudentContext();
        public LoginController(ApplicationDbContext context)
        //public LoginController()
        {
           _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            IdentityUser user = new IdentityUser();
            _signInManager.SignInAsync(user, true);
            return View();
        }
        public IActionResult SignUp()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Register(Login.Models.Login student)
        {
            if(ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
            
        }
    }
}
