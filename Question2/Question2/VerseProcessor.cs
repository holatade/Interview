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

        public  static string Verse(string animal, string sound)
        {
            return $" {Chorus()},\n And on his farm he had a {animal}, E I E I O.\n With a {DoubleSound(sound)} here and a {DoubleSound(sound)} there," +
                $"\n Here a {sound}, there a {sound}, ev'rywhere a {DoubleSound(sound)}.\n {Chorus()}.\n";
        }

        public static List<Animal> Animals()
        {
            return new List<Animal>() { new Animal("cow", "moo"), new Animal("dog", "boo"), new Animal("cat", "meow"), new Animal("pig", "wee"),
            new Animal("bee", "buzz"), new Animal("calve", "bleat"), new Animal("camel", "grunt"), new Animal("chick", "cheep"),
            new Animal("donkey", "bray"), new Animal("duck", "quack"), new Animal("goat", "bleat"), new Animal("cock", "crow"),
            new Animal("pigeon", "coo"), new Animal("horse", "neigh")};
        }
    }
}
