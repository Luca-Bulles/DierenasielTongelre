using DierenasielTongelreInterfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DierenasielTongelreInterfaces.Logic
{
    public interface IAnimalLogic
    {
        IAnimal EditAnimals(IAnimal animal);
        IAnimal GetById(IAnimal animal);
        IEnumerable<IAnimal> GetAllAnimals();
        void DeleteAnimal(int id);
        void CreateAnimal(IAnimal animal);
    }
}
