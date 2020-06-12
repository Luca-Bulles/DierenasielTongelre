using DierenasielTongelreLogic.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace DierenasielTongelreFactory
{
    public static class AnimalFactory
    {
        public static AnimalLogic GetAnimalLogic()
        {
            return new AnimalLogic();
        }
    }
}
