using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dojodachi.Models;
using System.Web;

namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        public aDojodachi Tutoro;

        public HomeController()
        {
            HttpContext.Current.Application["Tutoro"] = new aDojodachi();
            }
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Feed")]
        public string Feed()
        {
            return Tutoro.Feed();
        }
        [HttpGet("GetStatus")]
        public string GetStatus()
        {
            return Tutoro.GetStatus();
        }

    }
}
