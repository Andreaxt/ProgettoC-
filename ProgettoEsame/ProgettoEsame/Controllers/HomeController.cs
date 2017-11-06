using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProgettoEsame.Models;

namespace ProgettoEsame.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Contact contact = new Contact
            {
                FirstName = "Andrea",
                LastName = "fire"
            };


    

            return View(contact);
        }
    }
}