using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DierenasielTongelre.ViewModels
{
    public class AdoptIndexViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }
        public string DateOfBirth { get; set; }
        public bool Available { get; set; }
        public string DateOfRegistration { get; set; }
        public string ImageSrc { get; set; }
    }
}
