using NUnit.Framework;

namespace ChallengeApp.tests1
{
    public class TypeTests
    {
        [Test]
        public void WhenTwoNumberAreTheSame_GetCorrectResult()
        {
            int number1 = 1;
            int number2 = 1;
            
            Assert.That(number1, Is.EqualTo(number2));
        }

        [Test]
        public void WhenNumberIsLess_GetCorrectResult()
        {
            float number3 = 1.42f;
            float number4 = 2.50f;

            Assert.LessOrEqual(number3, number4);

        }

        [Test]
        public void WhenNamesAreNotTheSame_Get_Correct_Result()
        {
            string name1 = "Krystian";
            string name2 = "Amelia";

            Assert.That(name1, Is.Not.EqualTo(name2));
        }
    }
}