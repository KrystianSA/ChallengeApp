using ChallengeApp;

Employee employee1 = new Employee("Krystian", "Sąsiadek", "22");
Employee employee2 = new Employee("Beata", "Sąsiadek", "47");
Employee employee3 = new Employee("Andrzej", "Sąsiadek", "50");

employee1.AddGrades(2);
employee1.AddGrades(1);
employee1.AddGrades(7);
employee1.AddGrades(4);
employee1.AddGrades(3);

employee2.AddGrades(9);
employee2.AddGrades(4);
employee2.AddGrades(1);
employee2.AddGrades(9);
employee2.AddGrades(3);

employee3.AddGrades(1);
employee3.AddGrades(7);
employee3.AddGrades(9);
employee3.AddGrades(2);
employee3.AddGrades(1);

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

    Console.Write(employee1.Name + " ");
    Console.Write(employee1.Surname + " ");
    Console.Write("Lat = " + employee1.Age);
}

if (Max == Sumvalue2)
{
    Console.Write(employee2.Name + " ");
    Console.Write(employee2.Surname + " ");
    Console.Write("Lat = " + employee2.Age);

}

if (Max == Sumvalue3)
{
    Console.Write(employee3.Name + " ");
    Console.Write(employee3.Surname + " ");
    Console.Write("Lat = " + employee3.Age);
}
