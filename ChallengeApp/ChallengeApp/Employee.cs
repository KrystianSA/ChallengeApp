namespace ChallengeApp
{
    public class Employee : IEmployee
    {

        private List<float> grades = new List<float>();
        public Employee(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }

        public void AddGrade(double grade)
        {
            float valueInFloat = (float)grade;
            this.AddGrade(valueInFloat);
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (!float.TryParse(grade, out float result1))
            {
                switch (grade)
                {
                    case "A":
                    case "a":
                        this.grades.Add(100);
                        break;
                    case "B":
                    case "b":
                        this.grades.Add(80);
                        break;
                    case "C":
                    case "c":
                        this.grades.Add(80);
                        break;
                    case "D":
                    case "d":
                        this.grades.Add(80);
                        break;
                    case "E":
                    case "e":
                        this.grades.Add(80);
                        break;
                    default:
                        throw new Exception("invalid grade value");
                        break;
                }
            }
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Avarage = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Avarage += grade;
            }

            statistics.Avarage = statistics.Avarage / this.grades.Count;

            switch (statistics.Avarage)
            {
                case var avarage when avarage >= 80:
                    statistics.AvarageLetter = 'A';
                    break;
                case var avarage when avarage >= 60:
                    statistics.AvarageLetter = 'B';
                    break;
                case var avarage when avarage >= 40:
                    statistics.AvarageLetter = 'C';
                    break;
                case var avarage when avarage >= 20:
                    statistics.AvarageLetter = 'D';
                    break;
                default:
                    statistics.AvarageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}



