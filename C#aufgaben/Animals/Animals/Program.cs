using System;
using System.Collections.Generic;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            //List is a generic data type!
            //Automatic type inference: use "var" on the left side!
            var fishtank = new List<Fish>
            {
                new Goldfish("Hans-Joachim"),
                new Guppy("Herbert", "Jonas")
            };

            var garden = new List<Mammal>
            {
                new Cat("Frieda"),
                new Bunny("Günther", "Peter")
            };

            //Make the pets swim resp. move using for-each loops:
            foreach (var fish in fishtank)
            {
                fish.Swim();
            }

            foreach (var mammal in garden)
            {
                mammal.Move();
            }

            //Create a combined Pet list:
            var zoo = new List<Pet>(fishtank);
            zoo.AddRange(garden);

            //Attend all pets:
            foreach (var pet in zoo)
            {
                //Polymorphie (de) / Polymorphism (en):
                //"pet" is a base class object, but the subclass methods will be called.
                pet.Attend();

                //Stroke those pets that implement IStrokeable:
                IStrokeable strokeablePet = pet as IStrokeable;

                if (strokeablePet != null)
                {
                    strokeablePet.Stroke();
                }
                else
                {
                    Console.WriteLine("{0} is not strokeable :( so sad", pet);
                }

                /* if (pet is IStrokeable) 
                 * {
                 *    IStrokeable strokeablePet = (IStrokeable)pet;
                 *    strokeablePet.Stroke();
                 * }
                 * else
                 * {
                 *    ...
                 * }
                 */
            }
        }
    }
}
