﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DierenasielTongelreLogic
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Available { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public string ImageSrc { get; set; }
    }
}
