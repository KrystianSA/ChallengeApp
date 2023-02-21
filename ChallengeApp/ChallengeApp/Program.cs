using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine("");

var employee = new EmployeeInMemory("Krystian", "Sąsiadek");
employee.GradeAdded += EmployeeGradeAdded;
void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika:  ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception exception)
    {
        Console.WriteLine($"Exception catched:{exception.Message}");
    }
}

var Statistics = employee.GetStatistics();

Console.WriteLine(" ");
Console.Write($"Pracownik {employee.Name} {employee.Surname}");
Console.WriteLine("  ");
Console.WriteLine($"Ocena średnia: {Statistics.Avarage:N2} ");
Console.WriteLine($"Ocena mininalna: {Statistics.Min} ");
Console.WriteLine($"Ocena maksymalna: {Statistics.Max} ");
Console.WriteLine($"Ocena końcowa :{Statistics.AvarageLetter}");