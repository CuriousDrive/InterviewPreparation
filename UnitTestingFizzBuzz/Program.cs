using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestingFizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Enumerable.Range(1, 100).ToList();
        }

        public static bool IsDivisibleBy3(int num) => (num % 3 == 0) ? true : false;
        
        public static bool IsDivisibleBy5(int num) => (num % 5 == 0) ? true : false;
        
    }
}
