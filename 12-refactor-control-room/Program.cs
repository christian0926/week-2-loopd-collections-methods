List<string> bacons = new List<string>();
int hvorMange = 0;
string hva2 = "";
string hva = "";
int telle = 0;
while (true)
{
    Console.WriteLine();
    Console.WriteLine("1 - Add bacon");
    Console.WriteLine("2 - Remove bacon");
    Console.WriteLine("3 - List bacons");
    Console.WriteLine("4 - Quit");
    Console.WriteLine("5 - Add multiple bacons");
    Console.Write("Choice: ");

    string? choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.Write("Bacon name: ");
        string? name = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(name))
        {
            bacons.Add(name);
            Console.WriteLine("Bacon added.");
        }
    }
    else if (choice == "2")
    {
        Console.Write("Bacon name: ");
        string? name = Console.ReadLine();
        if (name is not null && bacons.Remove(name))
        {
            Console.WriteLine("Bacon removed.");
        }
        else
        {
            Console.WriteLine("Bacon not found.");
        }
    }
    else if (choice == "3")
    {
        if (bacons.Count == 0)
        {
            Console.WriteLine("No bacons registered.");
        }
        else
        {
            foreach (string bacon in bacons)
            {
                Console.WriteLine($"- {bacon}");
            }
        }
        Console.WriteLine(bacons.Count);
    }
    else if (choice == "4")
    {
        break;
    }
    else if (choice == "5")
    {
        hva2 = "";
        Console.WriteLine("Bacons, one ',' after every bacon");
        hva = Console.ReadLine();
        
        for (int j = 0; j < hva.Length; j++)
        {
            if (hva[j] == ',')
            {
                bacons.Add(hva2);
                hva2 = "";
            }
            else
            {
                hva2 = hva2 + hva[j];
            }
        }
    }
    else
    {
        Console.WriteLine("Unknown choice.");
    }
}

// TODO: Refaktorer den fungerende koden over til flere metoder.
