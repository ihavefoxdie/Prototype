using MinorClasses;
using System;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KidsMug kidsMug = new(1, 1, 1);
            var newKids = (KidsMug)kidsMug.ShallowCopy();
            var newerKids = (KidsMug)kidsMug.DeepCopy();
            kidsMug.Color.R = 1000;

            Console.WriteLine(newKids.Color.R);
            Console.WriteLine(newerKids.Color.R);
        }
    }
}
