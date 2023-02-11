using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine("");

Console.WriteLine("Podaj oceny kierownika oraz pracownika. Zakończenie wpisywania ocen sygnalizuje przycisk 'q'");
Console.WriteLine("Oceny są wystawiane w skali literowej od A do E, gdzie A oznacza najwyższą, E najniższą.");
Console.WriteLine(" ");

var supervisor = new Supervisor("Rafał", "Ciong", "45");
var employee = new Employee("Krystian", "Sąsiadek", "23");

while (true)
{
    Console.WriteLine("Podaj kolejną kierownika :  ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try { supervisor.AddGrade(input); }
    catch(Exception exception) { Console.WriteLine($"Exception catched:{exception.Message}"); }
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


var StatisticsSupervisor = supervisor.GetStatistics();
var StatisticsEmployee = employee.GetStatistics();

Console.WriteLine(" ");
Console.Write($"Kierownik {supervisor.Name} {supervisor.Surname} wiek : {supervisor.Age} lat");
Console.WriteLine("  ");
Console.WriteLine($"Ocena średnia: {StatisticsSupervisor.Avarage:N2} ");
Console.WriteLine($"Ocena mininalna: {StatisticsSupervisor.Min} ");
Console.WriteLine($"Ocena maksymalna: {StatisticsSupervisor.Max} ");
Console.WriteLine($"Ocena końcowa :{StatisticsSupervisor.AvarageLetter}");

Console.WriteLine(" ");
Console.Write($"Pracownik {employee.Name} {employee.Surname} wiek : {employee.Age} lat");
Console.WriteLine("  ");
Console.WriteLine($"Ocena średnia: {StatisticsEmployee.Avarage:N2} ");
Console.WriteLine($"Ocena mininalna: {StatisticsEmployee.Min} ");
Console.WriteLine($"Ocena maksymalna: {StatisticsEmployee.Max} ");
Console.WriteLine($"Ocena końcowa :{StatisticsEmployee.AvarageLetter}");