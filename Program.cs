using System;

namespace Assignment
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            carsappearing();
            Console.ReadKey();
        }
        
        static int carsappearing()
        {
            int cars = 0;
            for (int i = 0; i < 100; i++)
            {
                var rand = new Random();
                int time = rand.Next(1500, 2200);
                Thread.Sleep(time);
                Console.WriteLine("Car created");
                int queue = 0;
                queue++;
                cars ++;
            }
            return cars;
        }
    }
}