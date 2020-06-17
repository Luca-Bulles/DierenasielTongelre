using DierenasielTongelreInterfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DierenasielTongelreInterfaces.Queries
{
    public interface IAnimalQueries
    {
        void EditAnimals(IAnimal animal);
        IAnimal GetById(IAnimal animal);
        void DeleteAnimal(int id);
        IEnumerable<IAnimal> GetAllAnimals();
        void CreateAnimal(IAnimal animal);
    }
}
