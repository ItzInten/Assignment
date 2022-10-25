using System;

namespace Assignment
{
    internal class Program
    {

        static void Main(string[] args)
        {
            vehicle vehicle1 = new vehicle();
            Console.WriteLine(vehicle1.vehicleappearing());
            Console.ReadKey();
        }
    }
    class vehicle
    {
        int infinity, queue, vehicleamount = 0;
        public int vehicleappearing()
        {
            while (infinity == 0)
            {
                var rand = new Random();

                if (vehicleamount <4)
                {
                    int time = rand.Next(1500, 2200);
                    Thread.Sleep(time);
                    vehicleamount++;
                    Console.WriteLine("Vehicle created");
                }
                else 
                {
                    int time = rand.Next(1000, 2000);
                    Thread.Sleep(time);
                    vehicleamount++;
                    Console.WriteLine("Vehicle created, but queue now is " + vehicleamount);
                }
                queue++;
                int[,] array = new int[1, 4];
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (j==1)
                        {
                            array[i,j] = rand.Next(1,26);
                            Console.WriteLine(array[i, j]);
                        }
                        else if (j == 2)
                        {
                            array[i, j] = rand.Next(1,41);
                            Console.WriteLine(array[i, j]);
                        }
                        else if (j == 3)
                        {
                            array[i, j] = rand.Next(1,76);
                            Console.WriteLine(array[i, j]);
                        }
                        else
                        {
                            array[i, j] = rand.Next(1,4);
                            Console.WriteLine(array[i, j]);
                        }
                    }
                }
            }
            return vehicleamount;
        }
    }
}