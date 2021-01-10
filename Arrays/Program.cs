using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            //byte, short, float, int, long, double, decimal, char, bool
            //string
            //string[] strArray = new[] { "Pune", "Columbia", "Topeka", "Hyderabad", "Philadelphia" };

            int[] intArray1 = new[] { 6, 23, 3, 44, 53, 4, 71, 8 };
            string[] strArray1 = { "sir_yawnston","CodeWithSean", "CuriousDrive" ,"tbdgamer" };

            //Array.Sort(strArray1);
            string[] results = strArray1.Reverse().ToArray();
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }

            //NOTES
            // Add below namespaces to use LINQ extension methods
            //using System.Collections.Generic;
            //using System.Linq;


            //Array.Sort - *********************
            // this method take array as parameter and sorts it
            // for strings it sorts by the 1st char and if the char matches
            // then it checks 2nd char
            /*
            int[] intArray1 = new[] { 6, 23, 3, 44, 53, 4, 71, 8 };
            string[] strArray1 = { "sir_yawnston","CodeWithSean", "CuriousDrive" ,"tbdgamer" };

            Array.Sort(strArray1);

            foreach (var item in strArray1)
            {
                Console.WriteLine(item);
            }*/

            //SetValue - *********************
            // this sets the value (which is the first parameter)
            // at the index (which is the 2nd parameter)
            // it does not check the type of the value that you are setting
            //int[] intArray1 = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //intArray1[2] = new object();
            //intArray1[2, 2] = 2;
            //intArray1.SetValue(new object(), 1);
            //intArray1.SetValue("", 1);


            // Array.Reverse - *********************
            // this method reverses the array elements in the array
            // also this returns void and not the reveresed array
            /*int[] intArray1 = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Array.Reverse(intArray1);

            foreach (var item in intArray1)
            {
                Console.WriteLine(item);
            }*/

            // IndexOf - *********************
            // this returns the position of the first occurence of the element from the array
            // LastIndexOf returns the position of the last occurence of element from the array
            //int[] intArray1 = new[] { 3, 4, 3, 3, 3, 3, 3, 4 };
            //Console.WriteLine(Array.IndexOf(intArray1, 4));

            //GetValue - *********************
            // Gets the value at the specified position in the one-dimensional Array
            // The index is specified as a 32-bit integer.
            //int[] intArray1 = new[] { 1, 2, 3 };
            //Console.WriteLine(intArray1.GetValue(1));


            //GetLongLength - *********************
            // int[,,] intArray1 = new[,,] {{{1}},{{1}}};
            // Console.WriteLine(intArray1.GetLength(2));

            // CopyTo - *********************
            // this method copies elements from calling array to passed array
            // it starts copying at the start index 
            /*
            int[] intArray1 = new int[5];
            int[] intArray2 = new int[6];

            intArray1[0] = 1;
            intArray1[1] = 1;
            intArray1[2] = 1;
            intArray1[3] = 1;
            intArray1[4] = 1;

            intArray2[0] = 2;
            intArray2[1] = 2;
            intArray2[2] = 2;
            intArray2[3] = 2;
            intArray2[4] = 2;

            foreach (var item in intArray1)
            {
                Console.Write(item);
            }
            Console.WriteLine("");
            intArray1.CopyTo(intArray2, 1);
            foreach (var item in intArray2)
            {
                Console.Write(item);
            }*/

            // Array.Copy - *********************
            // this function copies elements from one array to another array
            // copy paste starts from the first position 
            // you pass the number of elements that you want replace as length/count

            /*int[] intArray1 = new int[5];
            int[] intArray2 = new int[5];

            intArray1[0] = 1;
            intArray1[1] = 1;
            intArray1[2] = 1;
            intArray1[3] = 1;
            intArray1[4] = 1;

            intArray2[0] = 2;
            intArray2[1] = 2;
            intArray2[2] = 2;
            intArray2[3] = 2;
            intArray2[4] = 2;

            foreach (var item in intArray1)
            {
                Console.Write(item);
            }
            Console.WriteLine("");
            Array.Copy(intArray1, intArray2, 6);
            foreach (var item in intArray2)
            {
                Console.Write(item);
            }*/

            // Array.Clear - *********************
            // this function clears the values of array from the start index 
            // and the length of array that you want to clear
            // start index and legth are mandatory parameters

            //Rank - *********************
            // this returns number of dimensions of the array

            //LongLength - *********************
            // this return total value that could be stored in the array
            // i.e 3 X 2 = 6

            //cool logic by Sean to replace a char in string - *********************
            //string Name = "Fahadddfgdfgdfgdfgdfgdfg";
            //int pos = 3;
            //string newValue = Name.Substring(0, pos) + "e" + Name.Substring(pos + 1);
            //Console.WriteLine(newValue);

            // Two Dimension int Array - 
            // this is how you create/define them
            // int[,] intArray = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //Console.WriteLine(intArray[2, 1]);


            //Length - *********************
            // this returns the size of the array.
            // it is same as what we assign when we initialize the array
            //int[] intArray = new int[10];
            //string[] strArray = new[] { "Pune", "Columbia", "Topeka", "Hyderabad", "Philadelphia" };

            //Console.WriteLine(intArray.Length);
            //Console.WriteLine(strArray.Length);


            //Properties -  - *********************
            // IsFixedSize is always true in case of Array
            // IsReadOnly is always false in case of Array
            //Console.WriteLine(array.IsFixedSize);
            //Console.WriteLine(array.IsReadOnly);

            // Definition - *********************
            // string[] strArray = new[] { "Pune", "Columbia", "Hyderabad", "Philadelphia" };
            // strArray[1] = "Colombia";
            // Console.WriteLine(strArray[1]);
            // note : you can not set value of string at particular position 
            // syntax for accessing the string array particular position 
            // and char at a string looks the same
        }
    }
}
