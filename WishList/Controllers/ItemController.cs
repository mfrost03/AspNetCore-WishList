using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WishList.Data;
using WishList.Models;

namespace WishList.Controllers
{
    public class ItemController: Controller
    {
        private readonly ApplicationDbContext _context;
        public ItemController(ApplicationDbContext context)
        {
            _context = context;

        }

        public IActionResult Index(Item item)
        {

            return View("Index");

        }
        [HttpGet]
        public IActionResult Create() 
        {

            return View("Create");

        }
        [HttpPost]
        public IActionResult Create(Item item)
        {
           
            RedirectToAction("Index");
            return View("Create");
            
        }
        public IActionResult Delete(int id)
        {

            RedirectToAction("Index");
            return View("Create");
        }
    }
}
