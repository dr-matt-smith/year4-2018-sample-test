using NUnit.Framework;

namespace UnityTest
{
    [TestFixture]
    internal class C_Percentages
    {

		[Test]
		public void ZeroPercentageCorrectWhenCreated()
		{
			// Arrange
			QuizManager qm = new QuizManager ();
			int expectedResult = 0;
			
			// Act
			int result = qm.GetPercentageQuestionsCorrect ();
			
			// Assert
			Assert.AreEqual (expectedResult, result);
		}	
		
		[Test]
		public void FiftyPercentageCorrectWhenOneCorrectOneWrong()
		{
			// Arrange
			QuizManager qm = new QuizManager ();
			int expectedResult = 50;
			qm.AddOneToCorrectTotal();
			qm.AddOneToWrongTotal();
			
			// Act
			int result = qm.GetPercentageQuestionsCorrect ();
			
			// Assert
			Assert.AreEqual (expectedResult, result);
		}
		
		[Test]
		public void OneHundredPercentageCorrectWhenOneCorrectZeroWrong()
		{
			// Arrange
			QuizManager qm = new QuizManager ();
			int expectedResult = 100;
			qm.AddOneToCorrectTotal();
			
			// Act
			int result = qm.GetPercentageQuestionsCorrect ();
			
			// Assert
			Assert.AreEqual (expectedResult, result);
		}

		[Test]
		public void TwentyFivePercentageCorrectWhenOneCorrectThreeWrong()
		{
			// Arrange
			QuizManager qm = new QuizManager ();
			int expectedResult = 25;
			qm.AddOneToCorrectTotal();
			qm.AddOneToWrongTotal();
			qm.AddOneToWrongTotal();
			qm.AddOneToWrongTotal();

			// Act
			int result = qm.GetPercentageQuestionsCorrect ();
			
			// Assert
			Assert.AreEqual (expectedResult, result);
		}

	}
}