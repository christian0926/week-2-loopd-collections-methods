string[] packets = { "P-100", "CORRUPT", "P-101", "P-102", "CORRUPT", "P-103" };
int processedCount = 0;
bool corupt = false;
int hvorMangeCorupt = 0;
foreach (string packet in packets)
{
    // TODO: Bruk continue for CORRUPT.
    // TODO: Prosesser resten og øk processedCount.
    if (packet == "CORRUPT")
    {
        corupt = true;
    }
    else
    {
        processedCount ++;
    }
}

Console.WriteLine($"Processed packets: {processedCount}");
if (corupt)
{
    for (int i = 0; i < packets.Length; i++)
    {
        if (packets[i] == "CORRUPT")
        {
            hvorMangeCorupt ++;
            Console.WriteLine($"pakke {i+1} er korupt");
        }
    }
    corupt = false;
}
Console.WriteLine($"{hvorMangeCorupt} av {packets.Length} pakker er korupt");