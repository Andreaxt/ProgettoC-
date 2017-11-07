using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProgettoEsame.Models;


namespace ProgettoEsame.Controllers
{
    //[Route("Home")]
    public class HomeController : Controller
    {


        //[Route("Index")]
        //[Route("Index/{id}")]
        public IActionResult Index(int id)
        {



            //Contact contact = new Contact
            //    {
            //        id = id,
            //        firstName = "Andrea",
            //        lastName = "fire"
            //    }
            //return View(contact);
            return Content("hey steve");
        }

        public IActionResult DownloadData() {
            //return File("/DownloadData/TestData.txt","text/plain","TooSexy.txt");

            return PhysicalFile("C:\\Users\\Andrea\\Desktop\\AppWeb\\Progetto\\ProgettoC-\\ProgettoEsame\\ProgettoEsame\\wwwroot\\DownloadData\\TestData.txt", "text/plain");
          
        }
    }
}