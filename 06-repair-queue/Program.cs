List<string> repairs = new List<string>
{
    "Replace antenna",
    "CANCELLED: Paint corridor",
    "Seal cargo hatch",
    "Recalibrate sensor",
    "CANCELLED: Move storage crate"
};

int jobNumber = 0;

foreach (string repair in repairs)
{
    // TODO: Hopp over kansellerte jobber og nummerer resten.
    if (!repair.Contains("CANCELLED"))
    {
        Console.WriteLine($"oppgave {jobNumber + 1}, {repairs[jobNumber]}");
    }
    jobNumber ++;
}
