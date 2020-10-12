using System;
using System.Diagnostics;
using System.Threading;
namespace ParallelAndAsync
{
    class Program
    {
        static void Main1()
        {
            //Multithreading
            //Thread thread = new Thread();

            //TPL - Tak Parallel Library
            //Task task = new Task();
            int[] numbers = { 23, 45, 12, 36, 26, 77, 26, 31, 14 };
            Stopwatch stopwatch = new Stopwatch();

            //Sequential
            stopwatch.Start();
            foreach (var num in numbers)
            {
                Compute(num);

            }
            Console.WriteLine($"Time taken (Sequqntial): {stopwatch.ElapseMilisecond}");

            //parallel
            stopwatch.Restart();
            Parallel.ForEach(numbers, num =>
            {
                Compute(num);
            });
            Console.WriteLine($"Time taken (Parallel): {stopwatch.ElapseMilisecond}");




        }

        static void Compute(int x)
        {
            Thread.Sleep(100);//milisecond delay
            Console.WriteLine($"Computed for {x}");


        }

        static void Main()
        {
            //Example : Making breakfast

            //Milk Tea
            //-Turn on burner(2s)
            //-Put on Kettle(2s)
            //-Add water(2s)
            //- Boil it (3min)
            //-Grid teas masala(10s)
            //-Add sugar and masalas(2s)
            //-Add milk(2s)
            //-Boil it (2min)

            //Fry egg
            //-Turn on burner(2s)
            //-Put on pan(2s)
            //-Add oil(2s)
            //- Crack eggs and stir it (2min)
            //-Fry it(1min)

            //Everything ready : Serve it

            //Sequential
            TurnOnBurner();
            Console.WriteLine("Burner turned on.");

            PutOnKettle();
            Console.WriteLine("Put kettle on kettle.");

            Add("water");
            Console.WriteLine("Added water.");

            Boil("water");
            Console.WriteLine("Boiled water");

            GridTeaMasala();
            Console.WriteLine("Grid tea masala");

            Add("Sugar");
            Console.WriteLine("Add sugar.");

            Add("Masala");
            Console.WriteLine("Add Masala.");

            Add("Milk");
            Console.WriteLine("Add Milk".);




        }
        private static void PutOnKettle()
        {
            Thread.Sleep(2000);
        }
        private static void TurnOnBurner()
        {
            Thread.Sleep(2000);
        }
        private static void AddWater()
        {
            Thread.Sleep(200);
        }
        private static void AddMilk()
        {
            Thread.Sleep(200);
        }
        private static void

    }
}
