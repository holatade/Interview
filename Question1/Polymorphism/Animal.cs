using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Animal
    {
        public string Chorus()
        {
           return "Old MacDonald had a farm, E I E I O";
        }

        public virtual string Verse()
        {
            return ($" {Chorus()},\n And on his farm he had a cow, E I E I O.\n With a moo moo here and a moo moo there," +
                $"\n Here a moo, there a moo, ev'rywhere a moo moo.\n {Chorus()}.\n");
        }
    }

    class Dog : Animal
    {
        public override string Verse()
        {
            return ($" {Chorus()},\n And on his farm he had a dog, E I E I O.\n With a bow bow here and a bow bow there," +
                $"\n Here a bow, there a bow, ev'rywhere a bow bow.\n {Chorus()}.\n");
        }
    }

    class Cat : Animal
    {
        public override string Verse()
        {
            return ($" {Chorus()},\n And on his farm he had a meow, E I E I O.\n With a meow meow here and a meow meow there," +
                $"\n Here a meow, there a meow, ev'rywhere a meow meow.\n {Chorus()}.\n");
        }
    }

    class Pig : Animal
    {
        public override string Verse()
        {
            return ($" {Chorus()},\n And on his farm he had a pig, E I E I O.\n With a wee wee here and a wee wee there," +
                $"\n Here a wee, there a wee, ev'rywhere a wee wee.\n {Chorus()}.\n");
        }
    }
}
