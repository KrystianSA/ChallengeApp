using ChallengeApp;

namespace ChallengeApp
{
    class Employee
    {
        private string name;
        private string surname;
        private string age;
        private List<int> Grades1 = new List<int>();
        private List<int> Grades2 = new List<int>();
        private List<int> Grades3 = new List<int>();
        private List<string> personalData = new List<string>();

        public Employee(string name, string surename, string age)
        {
            this.name = name;
            this.surname = surename;
            this.age = age;
        }

        public void AddGrades1(int number1, int number2, int number3, int number4, int number5)
        {
            this.Grades1.Add(number1);
            this.Grades1.Add(number2);
            this.Grades1.Add(number3);
            this.Grades1.Add(number4);
            this.Grades1.Add(number5);
        }

        public void AddGrades2(int number1, int number2, int number3, int number4, int number5)
        {
            this.Grades1.Add(number1);
            this.Grades1.Add(number2);
            this.Grades1.Add(number3);
            this.Grades1.Add(number4);
            this.Grades1.Add(number5);
        }

        public void AddGrades3(int number1, int number2, int number3, int number4, int number5)
        {
            this.Grades1.Add(number1);
            this.Grades1.Add(number2);
            this.Grades1.Add(number3);
            this.Grades1.Add(number4);
            this.Grades1.Add(number5);
        }

        public int SumGrades { get { return this.Grades1.Sum(); } }
        
        public string Showname
        { 
            get 
            {
                return this.name;
            } 
        }
        public string Showsurname
        { 
            get
            {
                return this.surname;
            }
        }
        public string ShowAge
        {
            get
            {
                return this.age;
            }
        }

    }
}
