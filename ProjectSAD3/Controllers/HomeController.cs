using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectSAD3.Data;
using ProjectSAD3.Models;
using ProjectSAD3.Repstory;
using ProjectSAD3.ViewModel;

namespace ProjectSAD3.Controllers
{
    public class HomeController : Controller
    {
        private RepstoryComputer computer;
        private IRepstory<Order> _reporder;
        private DContext db;
        public HomeController(DContext d)
        {
            db = d;
            computer = new RepstoryComputer(db);
            _reporder = new RepstoryOrder(db);
        }
        public IActionResult Index()
        {
            var c = computer.GetAll();
            return View(c);
        }

        public IActionResult GetItem(int id)
        {
            var c = computer.Get(id);
            var b = new ViewModelOrder()
            {
                computer = c
            };
            return View(b);
        }

        [HttpPost]
        public IActionResult GetItem(ViewModelOrder o)
        {
            Order op = o.order;
          var x=  _reporder.Add(op);
            if (x)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
    
}

