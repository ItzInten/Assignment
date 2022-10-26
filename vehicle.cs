class vehicle
{
    public int[,] array = new int[100, 2];
    public static int cars, vans, hgvs;
    public void vehicleappearing()
    {
        var rand = new Random();
        for (int i = 0; i < 100; i++)
        {
            if (i <= 3)
            {
                int time = rand.Next(1500, 2200);
                Thread.Sleep(time);
                Console.WriteLine("Vehicle created");
            }
            else
            {
                int time = rand.Next(1000, 2000);
                //Thread.Sleep(time);
                Console.WriteLine("Vehicle created, but queue now is " + (i+1));
            }
            for (int j = 0; j < 2; j++)
            {
                if (j == 0)
                {
                    array[i, j] = rand.Next(1, 4);
                    Console.WriteLine(array[i, j]);
                }
                else if (array[i, 0] == 1)
                {
                    array[i, j] = rand.Next(1, 26);
                    Console.WriteLine(array[i, j]);
                    break;
                }
                else if (array[i, 0] == 2)
                {
                    array[i, j] = rand.Next(1, 41);
                    Console.WriteLine(array[i, j]);
                    break;
                }
                else if (array[i, 0] == 3)
                {
                    array[i, j] = rand.Next(1, 76);
                    Console.WriteLine(array[i, j]);
                    break;
                }
            }
        }
        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if ((array[i,j] == 1))
                {
                    cars++;
                    break;
                }
                else if ((array[i,j] == 2))
                {
                    vans++;
                    break;
                }
                else if ((array[i,j] == 3))
                {
                    hgvs++;
                    break;
                }
            }
        }
    }
}