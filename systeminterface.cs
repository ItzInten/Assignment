class systeminterface
{
    public int line1, line2, line3, line4, line5, line6, line7, line8, line9;
    public void intrface()
    {
        vehicle vehicle2 = new vehicle();
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Queue: Cars: " + vehicle.cars + " Vans: " + vehicle.vans + " HGVs: " + vehicle.hgvs);
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Row 1:   Line 1:  " + vehicle.cars +  "  Line 4:  " + vehicle.cars +  "  Line 7:  " + vehicle.cars);
        Console.WriteLine("Row 2:   Line 2:  " + vehicle.vans +  "  Line 5:  " + vehicle.vans +  "  Line 8:  " + vehicle.vans);
        Console.WriteLine("Row 3:   Line 3:  " + vehicle.hgvs +  "  Line 6:  " + vehicle.hgvs +  "  Line 9:  " + vehicle.hgvs);
    }
}