using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Error()
        {
            return View("Error");
        }

        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
