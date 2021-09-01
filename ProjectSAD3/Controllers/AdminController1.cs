using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectSAD3.Data;
using ProjectSAD3.Models;
using ProjectSAD3.Repstory;
using ProjectSAD3.ViewModel;

namespace ProjectSAD3.Controllers
{
    [Route("Admin")]
    public class AdminController1 : Controller
    {
        IRepstory<Computer> _rep;
        private readonly DContext _db;
        private IHostingEnvironment hosts;
        IRepstory<Order> _repo;
        public AdminController1(DContext db,IHostingEnvironment _h)
        {
            _db = db;

            _rep = new RepstoryComputer(_db);
            hosts = _h;
            _repo = new RepstoryOrder(_db);
        }
      //  [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("pw")]
        public IActionResult Homes()
        {
            return View("../LoginController/page");
        }

        [HttpPost]
        public IActionResult Index(Computer c,IFormFile ImgPath)
        {
            if(ImgPath == null || ImgPath.Length == 0)
            {
                return Content("NO FILE ");
            }
            else
            {
                var path = Path.Combine(hosts.ContentRootPath, "wwwroot\\images", ImgPath.FileName);
               using (var str = new FileStream(path, FileMode.Create))
                {
                    ImgPath.CopyTo(str);
                    // return Content("Path "+ImgPath.FileName+" path "+path);
                    c.ImgPath = path;
                    _rep.Add(c);
                    TempData["msg"] = "Done ";
                    return RedirectToAction("Index", "Admin");
                }
                
            }

            
            return Content("");

        }
        [Route("Orders")]
        public IActionResult orders()
        {
            return View(_repo.GetAll());
        }
    }
}
