using System;
using System.Collections.Generic;
using System.Text;

namespace DataDriven
{
    public class VerseProcessor
    {
        private static string Chorus()
        {
            return "Old MacDonald had a farm, E I E I O";
        }

        private static string DoubleSound(string sound)
        {
            return $"{sound} {sound}";
        }

        public static string Verse(string animal, string sound)
        {
            return $" {Chorus()},\n And on his farm he had a {animal}, E I E I O.\n With a {DoubleSound(sound)} here and a {DoubleSound(sound)} there," +
                $"\n Here a {sound}, there a {sound}, ev'rywhere a {DoubleSound(sound)}.\n {Chorus()}.\n";
        }
        
    }
}
