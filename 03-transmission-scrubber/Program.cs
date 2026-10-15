string transmission = "AX?19??Q";
int markerCount = 0;

// TODO: Bruk for og transmission[i].
for (int i = 0; i < transmission.Length; i++)
{
    if (transmission[i] == '?')
    {
        markerCount ++;
        Console.WriteLine($"{i+1}");
    }
}
Console.WriteLine($"Marker count: {markerCount}");
