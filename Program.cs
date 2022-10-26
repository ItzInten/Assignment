using System;

namespace Assignment
{
    internal class Program
    {

        static void Main(string[] args)
        {
            vehicle vehicle1 = new vehicle();
            systeminterface intrfc = new systeminterface();
            vehicle1.vehicleappearing();
            intrfc.intrface();
            Console.ReadKey();
        }
    }
}