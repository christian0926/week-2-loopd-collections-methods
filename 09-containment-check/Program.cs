bool accepted = CanContain(9, 6, 1);

if (accepted)
{
    Console.WriteLine("ACCEPTED");
}
else
{
    Console.WriteLine("REJECTED");
}

static bool CanContain(int capacity, int occupied, int incoming)
{
    // TODO
    if (capacity >= occupied + incoming)
    {
        return true;
    }
    else
    {
        return false;
    }
}
