using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DierenasielTongelre.Models;
using DierenasielTongelre.ViewModels;
using DierenasielTongelreDAL.Queries;
using DierenasielTongelreDAL.DTO;

namespace DierenasielTongelre.Controllers
{
    public class AdoptController : Controller
    {
        private AnimalQueries db;

        public AdoptController(AnimalQueries db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            List<AnimalDTO> animals = db.GetAllAnimals();
            List<AdoptIndexViewModel> models = new List<AdoptIndexViewModel>();
            foreach (AnimalDTO animal in animals)
            {
                models.Add(new AdoptIndexViewModel()
                {
                    Name = animal.Name,
                    Race = animal.Race,
                    Color = animal.Color,
                    DateOfBirth = animal.DateOfBirth,
                    Available = animal.Available,
                    DateOfRegistration = animal.DateOfRegistration,
                    ImageSrc = animal.ImageSrc
                });
            }

            return View(models);
        }
    }
}