using NUnit.Framework;

namespace UnityTest
{
    [TestFixture]
    internal class B_Totals
    {

		[Test]
		public void TwoTotalAttemptedWhenOneCorrectOneWrong()
		{
			// Arrange
			QuizManager qm = new QuizManager ();
			int expectedResult = 2;
			qm.AddOneToCorrectTotal();
			qm.AddOneToWrongTotal();
			
			// Act
			int result = qm.GetTotalQuestionsAttempted ();
			
			// Assert
			Assert.AreEqual (expectedResult, result);
		}		
		
		[Test]
		public void TwoTotalAttemptedWhenTwoCorrectZeroWrong()
		{
			// Arrange
			QuizManager qm = new QuizManager ();
			int expectedResult = 2;
			qm.AddOneToCorrectTotal();
			qm.AddOneToCorrectTotal();
			
			// Act
			int result = qm.GetTotalQuestionsAttempted ();
			
			// Assert
			Assert.AreEqual (expectedResult, result);
		}		
		
		[Test]
		public void TwoTotalCorrectdWhenTwoCorrect()
		{
			// Arrange
			QuizManager qm = new QuizManager ();
			int expectedResult = 2;
			qm.AddOneToCorrectTotal();
			qm.AddOneToCorrectTotal();
			
			// Act
			int result = qm.GetTotalQuestionsCorrect ();
			
			// Assert
			Assert.AreEqual (expectedResult, result);
		}		

	}
}