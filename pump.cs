class Pump
{Queue<vehicle> waiting = new Queue<vehicle>();
    public bool pump1, pump2, pump3, pump4, pump5, pump6, pump7, pump8, pump9;
    int carscapasity = 50;
    int vanscapasity = 80;
    int hgvscapasity = 150;
    public void queue(int i, int j, int[,] array)
    {

        for (i = 0; i < 100; i++)
        {

            pump1 = true;
            Console.WriteLine("Pump 1 is busy");
            if (array[i, j] > 3)
            {
                Console.WriteLine("1");
                Thread.Sleep(array[i, j] * 100);
                Console.WriteLine(array[i, j] * 100);
                Console.WriteLine("Pump 1 is free now");
            }
            else if (array[i, j] > 3)
            {
                Console.WriteLine("2");
                Thread.Sleep(array[i, j] * 100);
                Console.WriteLine(array[i, j] * 100);
                Console.WriteLine("Pump 1 is free now");
            }
            else if (array[i, j] > 3)
            {
                Console.WriteLine("3");
                Thread.Sleep(array[i, j] * 100);
                Console.WriteLine(array[i, j] * 100);
                Console.WriteLine("Pump 1 is free now");
            }
            pump1 = false;
        }
    }
}