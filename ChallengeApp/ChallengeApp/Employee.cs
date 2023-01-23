using ChallengeApp;

namespace ChallengeApp
{
    class Employee
    {
 
        private List<int> Grades = new List<int>();

        public Employee(string name, string surename, string age)
        {
            this.Name = name;
            this.Surname = surename;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }
        public void AddGrades(int number)
        {
            this.Grades.Add(number);
        }

        public int SumGrades { get { return this.Grades.Sum(); } }
    }
}
