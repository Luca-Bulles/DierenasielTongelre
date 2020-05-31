using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DierenasielTongelre.Models;
using DierenasielTongelreInterfaces.Models;
using DierenasielTongelreInterfaces.Logic;
using DierenasielTongelreLogic;

namespace DierenasielTongelre.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
