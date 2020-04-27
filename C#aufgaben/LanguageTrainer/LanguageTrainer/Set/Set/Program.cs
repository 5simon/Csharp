using System;
using System.Collections.Generic;

namespace Set
{
    class Program
    {
        static void Main(string[] args)
        {
            MySet<string> set = new MySet<string>();

            set.Add("Test");
            set.Add("Another one");
            set.Add("Test");
            set.Add("12345");

            foreach (var s in set)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Number of elements in set: {0}", set.Count);

            set.Remove("12345");

            foreach (var s in set)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Is set empty? {0}", set.IsEmpty);
            set.Clear();
            Console.WriteLine("Is set empty? {0}", set.IsEmpty);

            MySet<string> a = new MySet<string>
            {
                "Test",
                "12345",
                "May the force be with you"
            };

            MySet<string> b = new MySet<string>
            {
                "May the force be with you",
                "Bazinga",
                "12345",
                "Test"
            };

            //Subset:
            Console.WriteLine("Is a subset of b? {0}", a.IsSubsetOf(b));
            Console.WriteLine("Is b subset of a? {0}", b.IsSubsetOf(a));

            //Union:
            var unionSet = a.UnionWith(b);
            Console.WriteLine("Union:");

            foreach (var element in unionSet)
            {
                Console.WriteLine(element);
            }

            //Intersection:
            var intersectSet = a.IntersectWith(b);
            Console.WriteLine("Intersection:");

            foreach (var element in intersectSet)
            {
                Console.WriteLine(element);
            }
        }
    }
}
