using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DierenasielTongelre.Models;
using DierenasielTongelre.ViewModels;
using DierenasielTongelreDAL.Queries;
using DierenasielTongelreDAL.DTO;
using DierenasielTongelreInterfaces.Models;
using DierenasielTongelreInterfaces.Logic;

namespace DierenasielTongelre.Controllers
{
    public class AdoptController : Controller
    {
        private AnimalQueries db;
        private readonly IAnimalLogic _animalLogic;
        public AdoptController(IAnimalLogic animalLogic)
        {
            _animalLogic = animalLogic;
        }

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
                    DateOfBirth = animal.DateOfBirth.ToString("d"),
                    Available = animal.Available,
                    DateOfRegistration = animal.DateOfRegistration.ToString("d"),
                    ImageSrc = animal.ImageSrc
                });
            }

            return View(models);
        }
        [HttpGet]
        public ActionResult Edit()
        {
            AnimalViewModel animalViewModel = new AnimalViewModel();
            _animalLogic.GetById(animalViewModel);

            return View(animalViewModel);
        }
        [HttpPost]
        public ActionResult Edit(AnimalViewModel animal)
        {
            _animalLogic.EditAnimals(animal);

            return RedirectToAction("Index");

        }
    }
}