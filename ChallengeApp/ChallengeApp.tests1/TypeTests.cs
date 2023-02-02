namespace ChallengeApp.tests1
{
   public class TypeTests
    {
        [Test]
         public void WhenTwoNumberAreTheSame_GetCorrectResult()
         {
             int number1 = 1;
             int number2 = 1;

             Assert.AreEqual(number1, number2);

         }
       
         public void WhenNumberIsLess_GetCorrectResult()
         {
             float number3 = 1.42f;
             float number4 = 2.50f;

             Assert.LessOrEqual(number3, number4);

         }
        
        public void WhenNamesAreNotTheSame_Get_Correct_Result()
        {
            string name1 = "Krystian";
            string name2 = "Amelia";

            Assert.AreNotEqual(name1, name2);
        }
    }
}