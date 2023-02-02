using System.Drawing;

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

            Assert.AreEqual(6,statistic);
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

            Assert.AreEqual(1,statistic);
        }
        [Test]
        public void WhenNumberAvarageIsCorrect_GetCorrectResult()
        {
            var employee = new Employee("Krystian", "Sąsiadek");
            employee.AddGrade(1);
            employee.AddGrade(3);
            employee.AddGrade(6);

            var result = employee.GetStatistics();
            var statistic = result.Avarage;

            Assert.AreEqual(4,statistic);
      
        }
    }
}
