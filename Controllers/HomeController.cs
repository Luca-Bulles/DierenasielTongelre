using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DierenasielTongelre.Models;
using DierenasielTongelreDAL.Queries;
using DierenasielTongelreDAL.DTO;
using DierenasielTongelreInterfaces.Models;

namespace DierenasielTongelre.Controllers
{
    public class HomeController : Controller
    {
        private AnimalQueries db;

        public HomeController(AnimalQueries db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            List<IAnimal> animals = db.GetAllAnimals();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
