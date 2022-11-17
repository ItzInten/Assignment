List<vehicle> queueing = new List<vehicle>();

void addanewcar()
{
    vehicle newVehicle = new vehicle();
    queueing.Add(newVehicle);
}

vehicle getQueue(int i)
{
    return queueing[i];
}

string getType()
{
    return queueing[0].getType();
}