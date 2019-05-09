using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ApiDemos.HebCal;
using Microsoft.AspNetCore.Mvc;
using ApiDemos.Web.Models;

namespace ApiDemos.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Convert(DateTime dateTime)
        {
            var api = new HebCalApi();
            return Json(api.ConvertToHebrew(dateTime));
        }

        public IActionResult Shabbos(string zip)
        {
            var api = new HebCalApi();
            return Json(api.GetUpcomingShabbosTimes(zip));
        }
    }
}
