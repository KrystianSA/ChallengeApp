using ChallengeApp;

var employee = new Employee("Krystian", "Sąsiadek");
employee.AddGrade("1");
employee.AddGrade(1);
employee.AddGrade(1);
employee.AddGrade(1);
var statistics1 = employee.GetStatistics();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine("Pętla foreach");
Console.WriteLine($"Avarage: {statistics1.Avarage:N2} ");
Console.WriteLine($"Min: {statistics1.Min} ");
Console.WriteLine($"Max: {statistics1.Max} ");
Console.WriteLine(" ");

Console.WriteLine("Pętla for");
Console.WriteLine($"Avarage: {statistics2.Avarage:N2} ");
Console.WriteLine($"Min: {statistics2.Min} ");
Console.WriteLine($"Max: {statistics2.Max} ");
Console.WriteLine(" ");

Console.WriteLine("Pętla do while");
Console.WriteLine($"Avarage: {statistics3.Avarage:N2} ");
Console.WriteLine($"Min: {statistics3.Min} ");
Console.WriteLine($"Max: {statistics3.Max} ");
Console.WriteLine(" ");

Console.WriteLine("Pętla while");
Console.WriteLine($"Avarage: {statistics4.Avarage:N2} ");
Console.WriteLine($"Min: {statistics4.Min} ");
Console.WriteLine($"Max: {statistics4.Max} ");