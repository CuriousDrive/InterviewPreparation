using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncBreakfast
{
    class Program
    {
        static async Task Main2(string[] args)
        {
            Console.WriteLine("SYNCHRONOUS METHOD CALLS");
            Coffee cup = new Coffee();
            Egg eggs = new Egg();
            Bacon bacon = new Bacon();
            Toast toast = new Toast();
            Juice oj = new Juice();
            //cup = PourCoffee();
            //Console.WriteLine("coffee is ready");

            //eggs = FryEggs(2);
            //Console.WriteLine("eggs are ready");

            //bacon = FryBacon(3);
            //Console.WriteLine("bacon is ready");

            //toast = ToastBread(2);
            //ApplyButter(toast);
            //ApplyJam(toast);
            //Console.WriteLine("toast is ready");

            //oj = PourOJ();
            //Console.WriteLine("oj is ready");
            //Console.WriteLine("Breakfast is ready!");

            Console.WriteLine("------------------------------");

            Console.WriteLine("A-SYNCHRONOUS METHOD CALLS");
            cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            Task<Egg> eggsTask = FryEggsAsync(2);
            Task<Bacon> baconTask = FryBaconAsync(3);
            Task<Toast> toastTask = MakeToastWithButterAndJamAsync(2); // composition of async methods

            // changed to MakeToastWithButterAndJamAsync => composition of async functions
            //toast = await toastTask;
            //ApplyButter(toast);
            //ApplyJam(toast);

            oj = PourOJ();
            Console.WriteLine("oj is ready");

            //best way => putting all the tasks in the list and checking which one done
            //by using Task.WhenAny methods and removing from the list
            var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
            while (breakfastTasks.Count() > 0)
            {
                var completedTask = await Task.WhenAny(breakfastTasks);
                
                if (completedTask == eggsTask)
                    Console.WriteLine(eggsTask);
                if (completedTask == baconTask)
                    Console.WriteLine("bacon is ready");
                if (completedTask == toastTask)
                    Console.WriteLine("toast is ready");

                breakfastTasks.Remove(completedTask);
            }

            //instead of listing all the await task statements
            //await Task.WhenAll(eggsTask, baconTask, toastTask); 

            //changed to WhenAll method
            //eggs = await eggsTask;
            //Console.WriteLine("eggs are ready");
            //bacon = await baconTask;
            //Console.WriteLine("bacon is ready");
            //toast = await toastTask;
            //Console.WriteLine("toast is ready");

            Console.WriteLine("Breakfast is ready!");
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) => Console.WriteLine("Putting jam on the toast");

        private static void ApplyButter(Toast toast) => Console.WriteLine("Putting butter on the toast");

        private static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        private static Bacon FryBacon(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }

        private static Egg FryEggs(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            Task.Delay(3000).Wait();
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }

        //async methods

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            await Task.Run(() =>
            {
                for (int slice = 0; slice < slices; slice++)
                {
                    Console.WriteLine("Putting a slice of bread in the toaster");
                }
                Console.WriteLine("Start toasting...");
                Task.Delay(3000).Wait();
                Console.WriteLine("Remove toast from toaster");
            });
            
            return new Toast();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            await Task.Run(() => 
            {
                Console.WriteLine($"putting {slices} slices of bacon in the pan");
                Console.WriteLine("cooking first side of bacon...");
                Task.Delay(3000).Wait();
                for (int slice = 0; slice < slices; slice++)
                {
                    Console.WriteLine("flipping a slice of bacon");
                }
                Console.WriteLine("cooking the second side of bacon...");
                Task.Delay(3000).Wait();
                Console.WriteLine("Put bacon on plate");
            });

            return new Bacon();
        }

        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Warming the egg pan...");
                Task.Delay(3000).Wait();
                Console.WriteLine($"cracking {howMany} eggs");
                Console.WriteLine("cooking the eggs ...");
                Task.Delay(3000).Wait();
                Console.WriteLine("Put eggs on plate");
            });

            return new Egg();
        }

        static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);

            return toast;
        }

    }

    internal class Juice
    {
    }

    internal class Toast
    {
    }

    internal class Coffee
    {
    }

    internal class Bacon
    {
    }

    internal class Egg
    {
        public int EggId;
    }
}