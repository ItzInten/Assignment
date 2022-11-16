class vehicle
{
    public int[,] array = new int[100, 2];
    public int i = 100; int j = 2;
    public static int cars, vans, hgvs;
    public void vehicleappearing()
    {
        Pump queue1 = new Pump();
        Thread myNewThread = new Thread(() => queue1.queue(i,j,array));
        myNewThread.Start();
        var rand = new Random();
        systeminterface intrfc1 = new systeminterface();
        Pump queingsystem = new Pump();
        for (i = 0; i < 100; i++)
        {
            for (j = 0; j < 2; j++)
            {
                if (j == 0)
                {
                    array[i, j] = rand.Next(1, 4);
                }
                else if (array[i, 0] == 1)
                {
                    array[i, j] = rand.Next(1, 26);
                    cars++;
                    intrfc1.intrface();
                    if (i <= 3)
                    {
                        int time = rand.Next(1500, 2200);
                        Thread.Sleep(time);
                        Console.WriteLine("Vehicle created");
                    }
                    else
                    {
                        int time = rand.Next(1000, 2000);
                        Thread.Sleep(time);
                        Console.WriteLine("Vehicle created, but queue now is " + (i + 1));
                    }
                    queue1.queue(i,j,array);
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                }
                else if (array[i, 0] == 2)
                {
                    array[i, j] = rand.Next(1, 41);
                    vans++;
                    intrfc1.intrface();
                    if (i <= 3)
                    {
                        int time = rand.Next(1500, 2200);
                        Thread.Sleep(time);
                        Console.WriteLine("Vehicle created");
                    }
                    else
                    {
                        int time = rand.Next(1000, 2000);
                        Thread.Sleep(time);
                        Console.WriteLine("Vehicle created, but queue now is " + (i + 1));
                    }
                    queue1.queue(i,j,array);
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                }
                else if (array[i, 0] == 3)
                {
                    array[i, j] = rand.Next(1, 76);
                    hgvs++;
                    intrfc1.intrface();
                    if (i <= 3)
                    {
                        int time = rand.Next(1500, 2200);
                        Thread.Sleep(time);
                        Console.WriteLine("Vehicle created");
                    }
                    else
                    {
                        int time = rand.Next(1000, 2000);
                        Thread.Sleep(time);
                        Console.WriteLine("Vehicle created, but queue now is " + (i + 1));
                    }
                    queue1.queue(i,j,array);
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                }
            }
        }
    }
}