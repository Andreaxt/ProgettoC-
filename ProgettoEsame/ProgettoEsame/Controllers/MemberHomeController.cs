using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProgettoEsame.Controllers
{
    [Route("[controller]")]
    public class MemberHomeController : Controller
    {
      
        //[Route("")]
        //[Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        //[Route("access")]
        public IActionResult AccessGranted() {
            return View();
        }
    }
}