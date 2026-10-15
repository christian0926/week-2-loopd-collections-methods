string[] planetCodes = { "ORION-4", "KAPPA-9", "LYRA-2", "NOVA-7", "VEGA-3" };
bool found = false;
int where = 0; 
// TODO: Skriv Length, første og siste element.
// TODO: Finn KAPPA-9 med en løkke.
Console.WriteLine($"the list is {planetCodes.Length} long, first is {planetCodes[0]}, the last is {planetCodes[planetCodes.Length - 1]}");
for (int i = 0; i < planetCodes.Length; i++)
{
    where ++;
    if (planetCodes[i] == "KAPPA-9")
    {
        found = true;
        break;
    }
}
Console.WriteLine($"Found KAPPA-9: {found}, nr {where}");
