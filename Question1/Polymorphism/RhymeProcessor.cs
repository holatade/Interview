using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class RhymeProcessor
    {
        public static void GenerateVerses()
        {
            Console.WriteLine(new Animal().Verse());
            Console.WriteLine(new Dog().Verse());
            Console.WriteLine(new Cat().Verse());
            Console.WriteLine(new Pig().Verse());
        }
    }
}
