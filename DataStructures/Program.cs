using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpBasics
{

    class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] names1 = new[] { "Fahad", "Adam", "Mullaji" };
            string[] names2 = new[] { "Monica", "Kendra", "Mullaji" };
            int[] numbers = { 11, 12, 13, 14, 15};
            string[] stringNumbers = { "11", "12", "13", "14", "15"};
            Student[] students = {  new Student() { Score = 10, Name = "Fahad"} ,
                                    new Student() { Score = 20, Name = "Monica"},
                                    new Student() { Score = 20, Name = "Joe"}};

            numbers.ToList().Select(n => n.ToString()).ToList();
            List<int> intNumbers = stringNumbers.Select(int.Parse).ToList();

            //-------------------- Linked List --------------------


            //-------------------- Linked List --------------------


            //-------------------- Stack --------------------
            Stack<string> languages = new Stack<string>();
            languages.Push("C#");
            languages.Push("JavaScript");
            languages.Push("Java");
            languages.Push("python");
            languages.Push("SQL");

            //if you try to pop an emty stack then it will throw an exception
            //Console.WriteLine(languages.Pop());
            //Console.WriteLine(languages.Pop());
            //Console.WriteLine(languages.Pop());
            //Console.WriteLine(languages.Pop());
            //Console.WriteLine(languages.Pop());

            //this will throw an exception if you try to peek an empty stack
            //Console.WriteLine(languages.Peek());
            //Console.WriteLine(languages.Peek());
            //Console.WriteLine(languages.Peek());
            //Console.WriteLine(languages.Peek());

            //languages.Prepend("Bash");
            //Console.WriteLine(languages.Pop());
            //Console.WriteLine(languages.Pop());
            //Console.WriteLine(languages.Pop());
            //Console.WriteLine(languages.Pop());
            //Console.WriteLine(languages.Pop());
            //Console.WriteLine(languages.Pop());

            //-------------------- Queue --------------------
            // => Fahad Mark Monica Tanvi Joe Erin Shayna Moo
            Queue<string> line = new Queue<string>();
            //line.Enqueue("Fahad");
            //line.Enqueue("Mark");
            ////dequeue method removed the first element in the queue to be removed
            ////Console.WriteLine(line.Dequeue());
            //line.Enqueue("Monica");
            //line.Enqueue("Tanvi");
            ////Console.WriteLine(line.Dequeue());
            //line.Enqueue("Erin");
            //line.Enqueue("Shayna");
            ////Console.WriteLine(line.Dequeue());
            //line.Enqueue("Joe");
            //line.Enqueue("Moo");

            //peek let's you look at the first element but it does not remove the element
            //Console.WriteLine(line.Peek());
            //Console.WriteLine(line.Peek());
            //Console.WriteLine(line.Peek());

            //if tried to dequeue when there are no items then you will get an exception
            //Console.WriteLine(line.Dequeue());

            //you can use TryDequeue to check if there any items left or not 
            //string result = "";
            //Console.WriteLine(line.TryDequeue(out result));
            //Console.WriteLine(result);

            //if tried to Peek when there are no items then you will get an exception
            //Console.WriteLine(line.Peek());

            //you can use TryPeek to check if there any items left or not 
            //string result = "";
            //Console.WriteLine(line.TryPeek(out result));
            //Console.WriteLine(result);

            //count of items
            //Console.WriteLine(line.Count());

            //you can convert your queue into a list and work on it
            //line.ToList().ForEach(s => Console.WriteLine(s));

            //-------------------- SORTED LIST --------------------
            //let's try with numbers first
            //not sure when I can use this why not just sort the existing list?
            //SortedList sortedList = new SortedList();
            //int index = 0;
            //for(int i = numbers.Length-1; i >= 0; i--)
            //{
            //    sortedList.Add(i,numbers[index]);
            //    index++;
            //}

            //foreach (var item in sortedList)
            //{
            //    DictionaryEntry dictionaryEntry = (DictionaryEntry)item;
            //    Console.WriteLine(dictionaryEntry.Key + " " + dictionaryEntry.Value);
            //}

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

            //var names = new List<string>();
            //names.AddRange(names1);
            //names.AddRange(names2);

            //addrange strings
            //names.ForEach(name => Console.WriteLine(name));

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

        }
    }
}
