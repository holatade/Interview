using System;
using System.Collections.Generic;
using System.Text;

namespace DataDriven
{
    public class RhymeProcessor
    {
        public static void GenerateVerses()
        {
            var animals = new List<Animal>() { new Animal("cow", "moo"), new Animal("dog", "boo"), new Animal("cat", "meow"), new Animal("pig", "wee") };
            foreach (var animal in animals)
            {
                Console.WriteLine(VerseProcessor.Verse(animal.Name, animal.Sound));
            }
        }
    }
}
