﻿using System;
using System.Collections.Generic;
using System.Text;
using DierenasielTongelreInterfaces.Logic;
using DierenasielTongelreInterfaces.Models;
using DierenasielTongelreInterfaces.Queries;

namespace DierenasielTongelreLogic.Logic
{
    public class AnimalLogic: IAnimalLogic
    {
        private IAnimalQueries animalQueries {get;}
        public AnimalLogic(IAnimalQueries _animalQueries)
        {
            animalQueries = _animalQueries;
        }
        public IAnimal EditAnimals(IAnimal animal)
        {
            animalQueries.EditAnimals(animal);

            return animal;
        }
        public IAnimal GetById(IAnimal animal)
        {
            return animalQueries.GetById(animal);
        }
        public IEnumerable<IAnimal> GetAllAnimals()
        {
            return animalQueries.GetAllAnimals();
        }
        public void DeleteAnimal(int id)
        {
            animalQueries.DeleteAnimal(id);
        }
        public void CreateAnimal(IAnimal animal)
        {
            animalQueries.CreateAnimal(animal);
        }
    }
}
