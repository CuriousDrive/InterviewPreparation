using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.ObjectModel;

namespace AsyncAwaitDemo
{
    class Testing
    {
        static async Task Main()
        {
            //Task makingCoffeeTask = MakeCoffee();
            //Task makingOmleteTask = MakeOmlete();

            //await makingOmleteTask;
            //await makingCoffeeTask;
            string name = "Fahad";
            Console.WriteLine(name.Remove(name.Length - 1));
           
        }

        public static void Display(params int[] b)
        {
            foreach (int i in b)
            {
                Console.WriteLine("ARRAY IS HAVING:{0}", i);
            }
        }

        public static async Task MakeCoffee()
        {
            Console.WriteLine("Started => making the coffee");
            await Task.Delay(4000);
            Console.WriteLine("Done => making the coffee");
        }

        public static async Task MakeOmlete()
        {
            Console.WriteLine("Started => making the omlete");
            await Task.Delay(3000);
            Console.WriteLine("Done => making the omlete");
        }
    }
}
