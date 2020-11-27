using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------- ARRAY LIST --------------------
            // array list is like array but array list is dynamic
            // you can add and remove items from the list
            // also you can push any type of item at run time
            //var arrayList = new ArrayList();
            //var arrayList2 = new ArrayList();
            //var intArray = new int[] {1,2,3 };

            // Add method
            //arrayList.Add(1);
            //arrayList.Add(1);
            //arrayList2.Add(1);
            //arrayList2.Add("Fahad");
            //arrayList2.Add(1);
            //arrayList2.Add("Adam");
            //arrayList2.Add("Mullaji");

            //add range method
            //arrayList.AddRange(arrayList2);
            //arrayList.AddRange(intArray);

            //accessing items from arraylist 
            //Console.WriteLine(arrayList[7]);

            //iterate an ArrayList
            //foreach (var item in arrayList)
            //    Console.WriteLine(item);

            //inserting elements in array list
            //arrayList.Insert(0, "Fahad");

            //insert range 
            //arrayList.InsertRange(0, new string[] { "Adam", "Adam", "Mullaji"});

            //remove items
            //arrayList.Remove("Fahad");

            //contains method
            //Console.WriteLine(arrayList.Contains("Faahad"));

            //foreach (var item in arrayList)
            //    Console.Write(item);

            /*  -------------------- LIST<T> --------------------
                List<T> equivalent of the ArrayList, which implements IList<T>.
                It comes under System.Collection.Generic namespace.
                List<T> can contain elements of the specified type. It provides compile-time type checking and doesn't perform boxing-unboxing because it is generic.
                Elements can be added using the Add(), AddRange() methods or collection-initializer syntax.
                Elements can be accessed by passing an index e.g. myList[0]. Indexes start from zero.
                List<T> performs faster and less error-prone than the ArrayList.
            */

            string[] names1 = new[] { "Fahad", "Adam", "Mullaji" };
            string[] names2 = new[] { "Monica", "Kendra", "Mullaji" };

            var names = new List<string>();
            names.AddRange(names1);
            names.AddRange(names2);

            //addrange strings
            //names.ForEach(name => Console.WriteLine(name);

            //accessing a List
            //Console.WriteLine(names[4]);

            //accessing a list using LINQ
            //var values = (from name in names
            //                where name.length > 5
            //                orderby name
            //                select name).tolist();

            //names.Clear();
            //Console.WriteLine(names.BinarySearch("Mullaji"));
            //names.ForEach(name => Console.WriteLine(name));

            //Console.WriteLine(names.Find(name => name.Contains("M"))); 

            //names.Sort();
            //names.ForEach(name => Console.WriteLine(name));


            /*  -------------------- SORTED LIST<T> --------------------*/


        }
    }
}
