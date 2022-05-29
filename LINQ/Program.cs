using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 5, 4, 3 };
            int[] intArray2 = { 1, 1, 1, 1, 1, 1, 1, 1 };
            string[] strArray = { "Chiplun", "Chiplun", "Hyderabad", "Topeka", "Pune", "Pune" };

            Student[] students = {  new Student() { StudentId = 1, Score = 10, Name = "Fahad"} ,
                                    new Student() { StudentId = 2, Score = 10, Name = "Tanvi"} ,
                                    new Student() { StudentId = 3, Score = 10, Name = "Mark"} ,
                                    new Student() { StudentId = 4, Score = 20, Name = "Monica"},
                                    new Student() { StudentId = 5, Score = 20, Name = "Joe"}};

            Parent[] parents = {  new Parent() { StudentId = 1, FirstName = "Rehana" , LastName = "Mullaji"} ,
                                    new Parent() { StudentId = 1,FirstName = "Adam" , LastName = "Mullaji"} ,
                                    new Parent() { StudentId = 4, FirstName = "Ken" , LastName = "Lord"} ,
                                    new Parent() { StudentId = 4, FirstName = "Denise" , LastName = "Lord"}};


            // Using group by on string array and sorting it by descending order
            // var groupedStringArray = strArray.GroupBy(s => s)
            //                                     .OrderByDescending(item => item.Count())
            //                                     .ToList();

            // foreach(var item in groupedStringArray)
            // {
            //    Console.WriteLine(item.Key + " : " + item.Count());
            // }

            // Grouping in custom data types
            // var groupedStudents = students.GroupBy(s => s.Score).ToList();

            // foreach(var items in groupedStudents)
            // {
            //    Console.WriteLine(items.Key);
            //    foreach(var item in items)
            //    {
            //        Console.WriteLine(item.Name + "-" + item.Score);
            //    }
            // }

            // Grouping by numbers
            // var groupedData = intArray2.GroupBy(number => number).ToList();

            // foreach(var item in groupedData)
            // {
            //    Console.WriteLine(item.Key + " " + item.Count());
            // }

            //first and last just returns first or last item
            //but single throws exception of it finds duplicate value
            
            // var something = intArray.First();
            // something = intArray.Last();
            
            // Console.WriteLine(something);

            // var something = from number in intArray
            //                 from city in strArray
            //                 select new { number, city };

            // var studentParents = students.Join(parents, 
            //                                     s => s.StudentId, 
            //                                     p => p.StudentId,
            //                                     (s,p) => new 
            //                                     {
            //                                         Student = s,
            //                                         Parent = p
            //                                     });

            // foreach (var item in studentParents)
            //     Console.WriteLine(item.Student.Name + ": " + item.Parent.FirstName + " + " + item.Parent.LastName);

            // var listCities = (from city in strArray
            //                 where city.StartsWith('P')
            //                 orderby city.Length descending
            //                 select city).ToList();

            //var listCities = strArray.Where(s => s.StartsWith('P'))
            //                        .OrderByDescending(s => s.Length)
            //                        .Select(s => s);
            
            // listCities.ForEach(s => Console.WriteLine(s));

            //var numbers = from number in intArray
            //              where number > 2
            //              orderby number descending
            //              select number;

            //var numbers = intArray.Where(number => number > 2)
            //                    .OrderByDescending(number => number)
            //                    .Select(number => number);

            //var stds = from student in students
            //           where student.Score > 10
            //           orderby student.Name descending
            //           select new { student.Name };

            //var stds = students.Where(s => s.Score > 10)
            //                    .OrderByDescending(s => s.Name)
            //                    .Select(s => s.Name);

        }

        class Student
        {
            public int StudentId { get; set; }
            public string Name { get; set; }
            public int Score { get; set; }
        }

        class Parent
        {
            public int ParentId { get; set; }
            public int StudentId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
