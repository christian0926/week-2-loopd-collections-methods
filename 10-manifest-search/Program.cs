List<string> manifest = new List<string> { "LENS", "BATTERY", "FILTER", "CABLE" };

Console.WriteLine(ContainsItem(manifest, "FILTER"));
Console.WriteLine(ContainsItem(manifest, "WRENCH"));

static bool ContainsItem(List<string> items, string search)
{
    // TODO: Søk med løkke.
    for (int i = 0; i < items.Count; i++)
    {
        if (items[i] == search)
        {
            return true;
        }
    }
    return false;
}
