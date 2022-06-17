using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    abstract class Vehicle : IVehicle, IVehicle2
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public abstract void Honk();
    }

    interface IVehicle
    {
        void Honk();
    }

    interface IVehicle2
    {

    }

    [Flags]
    enum CarTypes
    {
        Sedan = 1,
        HatchBack = 3,
        SUV = 2
    }

    class Car : Vehicle
    {
        public bool IndicatorState { get; set; }
        public override void Honk()
        {
            Console.WriteLine("Beep beep");
        }
    }

    class Crane : Vehicle
    {
        public int RotaryPosition { get; set; }

        public override void Honk()
        {
            Console.WriteLine("Boop boop");
        }
    }
}