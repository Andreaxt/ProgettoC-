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
        public IActionResult Index(int id)
        {
            Contact contact = new Contact
            {
                id = id,
                firstName = "Andrea",
                lastName = "fire"
            };


    

            return View(contact);
        }
    }
}