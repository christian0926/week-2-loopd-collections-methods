while (true)
{
    Console.Write("Command: ");
    string? command = Console.ReadLine();

    // TODO: Avslutt med break når command er EXIT eller null.
    // TODO: Ellers skriv Received: <command>.
    Console.WriteLine($"Received: {command}");
    command = command.ToUpper();
    
       if (command == "EXIT" || command == "")
    {
        break;
    }
}

Console.WriteLine("Receiver stopped.");
