Console.WriteLine("enter something");
string word = Console.ReadLine();
word = word.ToLower();
char[] wordInChar = word.ToCharArray();

Dictionary<char, int> charCount = new Dictionary<char, int>();

foreach (char c in wordInChar)
{
    charCount.TryGetValue(c, out int count);
    charCount[c] = count + 1;
}

foreach (KeyValuePair<char, int> pair in charCount)
{
    Console.WriteLine("{0}:{1}", pair.Key, pair.Value);
}





























/*using ChallengeApp;
using System.Xml.Linq;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine("");

Console.WriteLine("Wpisz nowego pracownika. Następnie podaj jego oceny. Zakończenie wpisywania ocen sygnalizuje przycisk 'q'");
Console.WriteLine("Oceny są wystawiane w skali literowej od A do E, gdzie A oznacza najwyższą, E najniższą.");
Console.WriteLine(" ");

Console.WriteLine("Podaj imię:  ");
string name = Console.ReadLine();

Console.WriteLine("Podaj nazwisko:  ");
string surname = Console.ReadLine();

Console.WriteLine("Podaj wiek:  ");
string age = Console.ReadLine();

var employee = new Employee(name,surname,age);


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika:  ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try { employee.AddGrade(input); }
    catch(Exception exception) { Console.WriteLine($"Exception catched:{exception.Message}"); }
}

var Statistics = employee.GetStatistics();

Console.WriteLine(" ");
Console.Write($"{employee.Name}");
Console.Write("  ");
Console.Write($"{employee.Surname}");
Console.Write("  ");
Console.WriteLine($"Wiek : {employee.Age}");
Console.WriteLine($"Ocena średnia: {Statistics.Avarage:N2} ");
Console.WriteLine($"Ocena mininalna: {Statistics.Min} ");
Console.WriteLine($"Ocena maksymalna: {Statistics.Max} ");
Console.WriteLine($"Ocena końcowa :{Statistics.AvarageLetter}");*/