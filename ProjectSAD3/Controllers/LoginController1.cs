using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectSAD3.Data;
using ProjectSAD3.Models;

namespace ProjectSAD3.Controllers
{
   [Route("login")]
    public class LoginController1 : Controller
    {
        private readonly DContext _db;
        public LoginController1(DContext db)
        {
            _db = db;
        }
      // [Route("login")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("page")]
        public IActionResult Homes()
        {
            return View("Admin");
        }

        // [Route("loginuser")]
        [HttpPost]
        public IActionResult Login_user(User user)
        {
            var result = (from item in _db.users
                          where item.Email == user.Email
                          && item.passw == user.passw
                          select item);
            if(result.Count()==1)
            {
                var x = result.FirstOrDefault();
                //HttpContext.Session.SetString("us",x.Email);
               // HttpContext.Session.SetString("pas", x.passw);
                return View("Admin",result.FirstOrDefault());
            }
            else
            {
                return RedirectToAction("index", "Login");
            }
          
        }
    }
}
