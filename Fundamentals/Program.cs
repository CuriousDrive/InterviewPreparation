using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            var sampleObject = new
            {
                FirstProperty = 1.1f,
                SecondProperty = "B"
            };

            Product sampleProduct = new Product();
            // Console.WriteLine(sampleProduct.MyProperty);


            List<char> lstChar =  "Fahad".Where(s => s == 'F').ToList();

            for (int i = 0; i < lstChar.Count(); i++)
            {
                Console.WriteLine(lstChar[i]);
            }
        }

        /*
         Properties have get and set accessors, which provide more control on how values are set or returned.
        C# allows you either to create a private field for storing the property value or 
        use auto-implemented properties that create this field automatically behind the scenes and provide the basic logic for the property procedures.
         */


        /*
         Difference between Structs and Classes: 
        Structs are value type whereas Classes are reference type. 
        Structs are stored on the stack whereas Classes are stored on the heap. 
        ... When you copy struct into another struct, a new copy of that struct gets created modified of one struct won't affect the value of the other struct.
         */
       

        abstract class Shape
        {
            public abstract int GetArea();

            public string GetName()
            {
                return "Fahad";
            }
        }

        public struct BaseStruct
        {
            
        }

        struct Product // :BaseStruct you can't inherit in structs
        {
            public string productName;
            public int MyProperty { get; set; }
        }
    }
}
