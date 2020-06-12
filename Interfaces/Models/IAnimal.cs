using System;
using System.Collections.Generic;
using System.Text;

namespace DierenasielTongelreInterfaces.Models
{
    public interface IAnimal
    {
        int Id { get; set; }
        string Name { get; set; }
        string Race { get; set; }
        string Color { get; set; }
        DateTime DateOfBirth { get; set; }
        bool Available { get; set; }
        DateTime DateOfRegistration { get; set; }
        string ImageSrc { get; set; }
    }
}
