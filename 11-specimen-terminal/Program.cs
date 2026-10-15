List<string> specimens = new List<string>();

while (true)
{
    Console.Write("Command (ADD/REMOVE/LIST/COUNT/QUIT): ");
    string? command = Console.ReadLine();

    // TODO: Implementer kommandoene.
    // Tips: specimens må IKKE opprettes på nytt inne i løkken.
    if (command.Contains("ADD"))
    {
        if (command.Contains("ADD ")){
            command = command.Replace("ADD ", "");
            specimens.Add(command);
        }
        else
        {
            Console.WriteLine("ADD");
            specimens.Add(Console.ReadLine());
        }
    }
    if (command.Contains("REMOVE"))
    {
        if (command.Contains("REMOVE ")){
            command = command.Replace("REMOVE ", "");
            specimens.Remove(command);
        }
        else
        {
            Console.WriteLine("REMOVE");
            specimens.Remove(Console.ReadLine());
        }
    }
    if (command == "LIST")
    {
        for (int i = 0; i < specimens.Count; i++)
        {
            Console.WriteLine(specimens[i]);
        }        
    }
    if (command == "COUNT")
    {
        Console.WriteLine(specimens.Count);
    }
    if (command == "QUIT")
    {
        break;
    }
}