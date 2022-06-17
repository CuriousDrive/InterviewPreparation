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
            int[] numbers = { 15, 77, 4, 14, 3};
            string[] stringNumbers = { "11", "12", "13", "14", "15"};
            Student[] students = {  new Student() { Score = 10, Name = "Fahad"} ,
                                    new Student() { Score = 20, Name = "Monica"},
                                    new Student() { Score = 20, Name = "Joe"}};

            numbers.ToList().Select(n => n.ToString()).ToList();
            List<int> intNumbers = stringNumbers.Select(int.Parse).ToList();

            //-------------------- Stack --------------------
            // Stack<string> languages = new Stack<string>();
            // languages.Push("C#");
            // languages.Push("JavaScript");
            // languages.Push("Java");
            // languages.Push("Python");
            // languages.Push("SQL");

            //if you try to pop items out of a stack after all the items are popped then it will throw an exception
            // Console.WriteLine(languages.Pop());
            // Console.WriteLine(languages.Pop());
            // Console.WriteLine(languages.Pop());
            // Console.WriteLine(languages.Pop());
            // Console.WriteLine(languages.Pop());

            // this will throw an exception if you try to peek an empty stack
            // Console.WriteLine(languages.Peek());
            // Console.WriteLine(languages.Peek());
            // Console.WriteLine(languages.Peek());
            // Console.WriteLine(languages.Peek());

            //var newLangs = languages.Prepend("Bash");

            // Console.WriteLine(newLangs.Count());
            //languages.TryPop();

            // Console.WriteLine(languages.Pop());
            // Console.WriteLine(languages.Pop());
            // Console.WriteLine(languages.Pop());
            // Console.WriteLine(languages.Pop());
            // Console.WriteLine(languages.Pop());
            //Console.WriteLine(languages.Pop());

            //-------------------- Queue --------------------
            // => Fahad Mark Monica Tanvi Joe Erin Shayna Moo
            Queue<string> line = new Queue<string>();
            line.Enqueue("Fahad");
            line.Enqueue("Mark");
            //dequeue method removed the first element in the queue to be removed
            //Console.WriteLine(line.Dequeue());
            line.Enqueue("Monica");
            line.Enqueue("Tanvi");
            //Console.WriteLine(line.Dequeue());
            line.Enqueue("Erin");
            line.Enqueue("Shayna");
            //Console.WriteLine(line.Dequeue());
            line.Enqueue("Joe");
            line.Enqueue("Moo");

            //peek let's you look at the first element but it does not remove the element
            // Console.WriteLine(line.Peek());
            // Console.WriteLine(line.Peek());
            // Console.WriteLine(line.Peek());

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

            //-------------------- ARRAY LIST --------------------
            
            // Array list is like array but array list is dynamic
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

            //-------------------- DICTIONATY --------------------

            // Dictionary<int, string> rollNumberAndName = new Dictionary<int, string>();

            // rollNumberAndName.Add(1, "Fahad");
            // rollNumberAndName.Add(2, "Monica");
            // rollNumberAndName.Add(3, "Mark");
            
            // rollNumberAndName[1] = "Tanvi";

            // Console.WriteLine(rollNumberAndName[1]);

            // var list = rollNumberAndName.Select(x => x.Key).ToList();

            
            //-------------------- TUPLES --------------------

            // List<(int, double)> listValues =  new List<(int, double)>();

            // (int value1, int value2) values = (1,2);

            // listValues.Add((10,10));
            // listValues.Add((10,20));
            // listValues.Add((10,30));
            // listValues.Add((10,40));

            // foreach (var item in listValues)
            // {
            //     Console.WriteLine(item.Item1 + ":" + item.Item2);
            // }

            //-------------------- SORTED LIST --------------------
            
            // let's try with numbers first
            // the keys gets sorted as the numbers are inserted into the 
            
            // SortedList sortedList = new SortedList();
            // Console.WriteLine("---- Unsorted List ----");
            
            // for(int i = 0; i < numbers.Length; i++)
            // {
            //     Console.WriteLine(numbers[i]);
            //     sortedList.Add(numbers[i], i);
            // }

            // Console.WriteLine("---- Sorted List ----");
            // foreach(var item in sortedList.Keys)
            // {
            //     Console.WriteLine(item);
            // }

            // this will throw an exception
            // sortedList.Add(15,99);

            //-------------------- HASHTABLE --------------------

            Hashtable numberNames = new Hashtable();
            
            numberNames.Add(1,"One"); //adding a key/value using the Add() method
            numberNames.Add(2,"Two");
            numberNames.Add(3,"Three");

            foreach(DictionaryEntry item in numberNames)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }

            //-------------------- HASHSET --------------------

            // HashSet<int> hs = new HashSet<int>();

            // hs.Add(1);
            // hs.Add(3);
            // hs.Add(5);
            // hs.Add(7);
            // hs.Add(9);

            // Console.WriteLine(String.Join('\n', hs));
        }

        // Tuples as method parameters and return types
        static (int, string, string) DisplayTuple((int,string,string) person)
        {
            Console.WriteLine($"Id = { person.Item1}");
            Console.WriteLine($"First Name = { person.Item2}");
            Console.WriteLine($"Last Name = { person.Item3}");

            return Tuple.Create(1, "Bill", "Gates");
        }
    }
}
