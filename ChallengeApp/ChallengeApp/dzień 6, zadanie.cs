using ChallengeApp;

Employee employee1 = new Employee("Krystian", "Sąsiadek", "22");
Employee employee2 = new Employee("Beata", "Sąsiadek", "47");
Employee employee3 = new Employee("Andrzej", "Sąsiadek", "50");

employee1.AddGrades1(1, 3, 3, 6, 8);
employee2.AddGrades2(2, 5, 5, 1, 8);
employee3.AddGrades3(1, 3, 7, 9, 2);

var Sumvalue1 = employee1.SumGrades;
var Sumvalue2 = employee2.SumGrades;
var Sumvalue3 = employee3.SumGrades;

int[] MaxValue = { Sumvalue1, Sumvalue2, Sumvalue3 };
var Max = MaxValue.Max();
Console.Write("Pracownik z najlepszym wynikiem osiągnął sumę = ");
Console.WriteLine(Max);
Console.Write("Był nim : ");

if (Max == Sumvalue1)
{

    Console.Write(employee1.Showname + " ");
    Console.Write(employee1.Showsurname + " ");
    Console.Write("Lat = " + employee1.ShowAge);
}

if (Max == Sumvalue2)
{
    Console.Write(employee2.Showname + " ");
    Console.Write(employee2.Showsurname + " ");
    Console.Write("Lat = " + employee2.ShowAge);

}

if (Max == Sumvalue3)
{
    Console.Write(employee3.Showname + " ");
    Console.Write(employee3.Showsurname + " ");
    Console.Write("Lat = " + employee3.ShowAge);
}