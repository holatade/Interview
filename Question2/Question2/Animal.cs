using System;
using System.Collections.Generic;
using System.Text;

namespace DataDriven
{
    public class Animal
    {
        Animal()
        {
        }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public string Name { get; set; }
        public string Sound { get; set; }
    }
}
