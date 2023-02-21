namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get;}
        string Surname { get; }
        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(string grade);
        void AddGrade(int grade);
        Statistics GetStatistics();
    }
}
