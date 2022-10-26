class systeminterface
{
    public void intrface()
    {
        vehicle vehicle2 = new vehicle();
        Console.WriteLine("Queue: Cars: " + vehicle.cars + " Vans: " + vehicle.vans + " HGVs: " + vehicle.hgvs);
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Row 1:       1         4         7");
        Console.WriteLine("Row 2:       2         5         8");
        Console.WriteLine("Row 3:       3         6         9");
    }
}