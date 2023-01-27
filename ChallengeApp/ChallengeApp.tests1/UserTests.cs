namespace ChallengeApp.tests1
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoScores_SchouldCorrectResult()
        {
            var user = new User("Krystian", "S�siadek");

            user.AddScore(1);
            user.AddScore(2);

            var result = user.Result;

            Assert.AreEqual(3, result);
        }

        public void WhenUserLoseTwoScores_SchouldCorrectResult()
        {
            var user = new User("Krystian", "S�siadek");

            user.SubtractScore(-1);
            user.SubtractScore(-2);

            var result = user.Result;

            Assert.AreEqual(-3, result);
        }

        public void WhenUserGetAndLoseScore_SchouldCorrectResult()
        {
            var user = new User("Krystian", "S�siadek");

            user.AddScore(1);
            user.SubtractScore(-2);

            var result = user.Result;

            Assert.AreEqual(1, result);

        }
    }
}