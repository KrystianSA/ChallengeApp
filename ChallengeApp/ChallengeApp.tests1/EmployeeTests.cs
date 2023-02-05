using NUnit.Framework;
namespace ChallengeApp.tests1
{
    public class EmployeeTests
    {
        [Test]
        public void WhenNumberIsTheHighest_GetCorrectResult()
        {
            var employee = new Employee("Krystian", "Sąsiadek");
            employee.AddGrade(1);
            employee.AddGrade(3);
            employee.AddGrade(6);

            var result = employee.GetStatistics();
            var statistic = result.Max;

            Assert.That(6, Is.EqualTo(statistic));
        }

        [Test]
        public void WhenNumberIsTheLowest_GetCorrectResult()
        {
            var employee = new Employee("Krystian", "Sąsiadek");
            employee.AddGrade(1);
            employee.AddGrade(3);
            employee.AddGrade(6);

            var result = employee.GetStatistics();
            var statistic = result.Min;

            Assert.That(1, Is.EqualTo(statistic));
        }
        [Test]
        public void WhenNumberAvarageIsCorrect_GetCorrectResult()
        {
            var employee = new Employee("Krystian", "Sąsiadek");
            employee.AddGrade(3);
            employee.AddGrade(3);
            employee.AddGrade(6);

            var result = employee.GetStatistics();
            var statistic = result.Avarage;

            Assert.That(4, Is.EqualTo(statistic));
        }

        [Test]
        public void WhenAvarageLetterIsCorrect_GetCorrrectResult()
        {
            var employee = new Employee("Krystian", "Sąsiadek");
            employee.AddGrade(30);
            employee.AddGrade(30);
            employee.AddGrade(60);

            var statistics = employee.GetStatistics();

            Assert.That('C',Is.EqualTo(statistics.AvarageLetter));

        }
    }
}