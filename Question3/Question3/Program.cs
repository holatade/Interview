using DataDriven;
using System;
using System.Collections.Generic;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();
            Console.WriteLine("Welcome");

            bool inputFieldLoop = true;

            while(inputFieldLoop is true)
            {
                var name = ProcessAnimalName();

                var sound = PocessAnimalSound();

                animals.Add(new Animal(name, sound));
                Console.Write("Would you like to add another animal - type y for Yes or n for No : ");
                var input = Console.ReadLine();
                if (input is "n") break;
            }
            Console.WriteLine();
            AnimalRhymeProcessor.GenerateVerses(animals);
        }

        private static bool  WordValidation(string word)
        {
            if (word.Contains(" "))
            {
                Console.WriteLine("Please input a word with no white space");
                return true;
            }
            return false;
        }

        private static string ProcessAnimalName()
        {
            bool repeat = true;
            string name = "";
            while(repeat is true)
            {
                Console.Write("Name of animal : ");
                name = Console.ReadLine(); 
                repeat = WordValidation(name);
                if (repeat is false) break;
            }
            return name;
        }

        private static string PocessAnimalSound()
        {
            bool repeat = true;
            string sound = "";
            while (repeat is true)
            {
                Console.Write("Sound of animal : ");
                sound = Console.ReadLine();
                repeat = WordValidation(sound);
                if (repeat is false) break;
            }
            return sound;
        }
    }
}
