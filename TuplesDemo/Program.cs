using System;
using System.Collections.Generic;
using System.Linq;

namespace TuplesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating list of tuples
            //List<Tuple<double, int>> listTuples = new List<Tuple<double, int>>();

            //different ways to create tuples
            //(double, int) firstTuple = (11.1, 4);
            //listTuples.Add(firstTuple.ToTuple());

            //var secondTuple = (5.5, 4);
            //listTuples.Add(secondTuple.ToTuple());

            //listTuples.Add(Tuple.Create(99.0, 12));

            //Console.WriteLine($"{listTuples[1].Item1} {listTuples[1].Item2}");

            //a way to name your tuple items
            //var vowels = (firstLetter : "a", "e", "i", "o", "u");
            //Console.WriteLine(vowels.firstLetter);

            //var maxMin = FindMaxMin(new int[] { 1, 2, 3, 4, 5, 6, 7, });
            //Console.WriteLine(maxMin);

            //another way to name tuple items
            //var sum = 99;
            //var count = 5;
            //var tuple = (sum, count);
            //Console.WriteLine(tuple.sum);

            //assigment operators for tuples
            //var t1 = (11, 11);
            //var t2 = (0, 0.5);
            //t2 = t1;
            //Console.WriteLine(t2);

            //assgning the property names
            //var nameAge = ("Fahad", 32);
            //(string name, int age) = nameAge;
            //(string name, int age) temp = nameAge;
            //Console.WriteLine($"name is {temp.name} and age is {temp.age}");

            //another way to assign property names
            //var nameAge = ("Fahad", 32);
            //var (name, age) = nameAge;
            //Console.WriteLine($"name is {name} and age is {age}");

            //assigning a tuple to bunch of variables
            //var destination = string.Empty;
            //var distance = 0.0;
            //var t = ("post office", 3.6);
            //(destination, distance) = t;
            //Console.WriteLine($"Distance to {destination} is {distance} kilometers.");

            //tuples equality
            //(byte a, byte b) t1 = (10, 1);
            //(int x, int y) t2 = (11, 1);
            //if (t1 == t2) Console.WriteLine(true);
            //else Console.WriteLine(false);

            //in this example you can see that Tuples does not consider the field names
            //var t1 = (A: 5, B: 10);
            //var t2 = (B: 5, A: 10);
            //Console.WriteLine(t1 == t2);  // output: True
            //Console.WriteLine(t1 != t2);  // output: False
        }

        public static (int, int) FindMaxMin(int[] numbers)
        {
            return (numbers.Max(), numbers.Min());
        }
    }
}
