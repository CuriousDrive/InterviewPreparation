using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesDemo
{
    class Program
    {
        public delegate int Calculate(int x, int y);

        static void Main(string[] args)
        {
            //declaring delegates on top of class
            //Calculate add = (x, y) => x + y;
            //Calculate multiply = (x, y) => x * y;
            //Calculate divide = (x, y) => x / y; ;
            //Calculate substract = (x, y) => x - y;

            //Console.WriteLine(add(10,10));
            //Console.WriteLine(multiply(10,10));
            //Console.WriteLine(divide(10, 10));
            //Console.WriteLine(substract(10, 10));

            //declaring the delegate function at runtime, by using Func<>
            //Func<int,int,int> add = (x,y) => { return x + y; };
            //Func<int,int,int> substract = (x,y) => { return x - y; };
            //Func<int,int,int> multiply = (x,y) => { return x * y; };
            //Func<int,int,int> divide = (x,y) => { return x / y; };

            //Console.WriteLine(add(10, 13));
            //Console.WriteLine(substract(10, 13));
            //Console.WriteLine(multiply(10, 13));
            //Console.WriteLine(divide(10, 13));

            //you can also use actions if the functions that you are calling does not have return type
            //Action<int, int> add = (x, y) => { Console.WriteLine(x + y); };
            //Action<int, int> substract = (x, y) => { Console.WriteLine(x - y); };
            //Action<int, int> multiply = (x, y) => { Console.WriteLine(x * y); };
            //Action<int, int> divide = (x, y) => { Console.WriteLine(x / y); };

            //add(10,20);multiply(10, 24);substract(10, 12);divide(11, 11);

            //predicate
            Predicate<int> predicate = (number) => { return number > 20 ? true : false; };
            List<string> numbers = new List<string> { "10", "20", "5" };
            Console.WriteLine(String.Join(" ",numbers.Select(int.Parse).ToList().FindAll(predicate).ToArray()));
        }
    }
}
