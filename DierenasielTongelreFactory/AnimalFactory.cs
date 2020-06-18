using DierenasielTongelreDAL.Queries;
using DierenasielTongelreInterfaces.Queries;
using DierenasielTongelreLogic.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace DierenasielTongelreFactory
{
    public static class AnimalFactory
    {
        public static IAnimalQueries _animalQueries = new AnimalQueries();
        public static AnimalLogic GetAnimalLogic()
        {
            return new AnimalLogic(_animalQueries);
        }
    }
}
