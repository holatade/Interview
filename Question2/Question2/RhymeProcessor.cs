using DataDriven;
using System;
using System.Collections.Generic;
using System.Text;

namespace Question2
{
    public class RhymeProcessor
    {
        public static void GenerateVerses()
        {
            var animals = VerseProcessor.Animals();
            foreach (var animal in animals)
            {
                Console.WriteLine(VerseProcessor.Verse(animal.Name, animal.Sound));
            }
        }
    }
}
