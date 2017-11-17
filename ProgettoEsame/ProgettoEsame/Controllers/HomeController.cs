using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProgettoEsame.Models;
using ProgettoEsame.ViewsModels;


namespace ProgettoEsame.Controllers
{
    //[Route("Home")]
    public class HomeController : Controller
    {
        [HttpGet]

        public IActionResult IndexWithForm() {
            return View("IndexWithForm");
        }

        //[Route("Index")]
        //[Route("Index/{id}")]
        //[FromQuery] per prendere dalla barra url

        [HttpPost]

        public IActionResult Index(Contact contact)
        {
            if (ModelState.IsValid)
            {
                Customer customer = new Customer
                {
                    Id = 2,
                    CustomerName = "The Company"
                };


                HomeIndexViewModel vm = new HomeIndexViewModel
                {
                    Contact = contact,
                    Customer = customer
                };

                return View(vm);
            }

            return View("IndexWithForm");
            //Contact contact = new Contact
            //{
            //    Id = 1,
            //    FirstName = "Andrea",
            //    LastName = "fire"
            //};
        
        }

        public IActionResult DownloadData() {
            //return File("/DownloadData/TestData.txt","text/plain","TooSexy.txt");

            return PhysicalFile("C:\\Users\\Andrea\\Desktop\\AppWeb\\Progetto\\ProgettoC-\\ProgettoEsame\\ProgettoEsame\\wwwroot\\DownloadData\\TestData.txt", "text/plain");
          
        }
    }
}