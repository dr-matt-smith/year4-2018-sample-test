using NUnit.Framework;

namespace UnityTest
{
    [TestFixture]
    internal class D_PassPercentage
    {

		[Test]
		public void PassPercentageFiftyWhenCreated()
		{
			// Arrange
			QuizManager qm = new QuizManager ();
			int expectedResult = 50;
			
			// Act
			int result = qm.GetPassPercentage ();
			
			// Assert
			Assert.AreEqual (expectedResult, result);
		}	
		
		[Test]
		public void SetGetPassPercentageToSeventyFive()
		{
			// Arrange
			QuizManager qm = new QuizManager ();
			float expectedResult = 75;
			qm.SetPassPercentage (75);
			
			// Act
			int result = qm.GetPassPercentage ();

			// Assert
			Assert.AreEqual (expectedResult, result);
		}

		[Test]
		public void PassPercentageLessThanOneNotRecordedZero()
		{
			// Arrange
			QuizManager qm = new QuizManager ();
			float expectedResult = 10;
			qm.SetPassPercentage (10);
			qm.SetPassPercentage (0);

			// Act
			int result = qm.GetPassPercentage ();
			
			// Assert
			Assert.AreEqual (expectedResult, result);
		}
		
		
		[Test]
		public void PassPercentageLessThanOneNotRecordedMinusOne()
		{
			// Arrange
			QuizManager qm = new QuizManager ();
			float expectedResult = 50;
			qm.SetPassPercentage (-1);

			// Act
			int result = qm.GetPassPercentage ();
			
			// Assert
			Assert.AreEqual (expectedResult, result);
		}

		[Test]
		public void PassPercentageMoreThanOneHundredNotRecordedOneHundredAndOne()
		{
			// Arrange
			QuizManager qm = new QuizManager ();
			float expectedResult = 50;
			qm.SetPassPercentage (101);
			
			// Act
			int result = qm.GetPassPercentage ();
			
			// Assert
			Assert.AreEqual (expectedResult, result);
		}


		[Test]
		public void PassPercentageMoreThanOneHundredeNotRecordedTwoHundred()
		{
			// Arrange
			QuizManager qm = new QuizManager ();
			float expectedResult = 10;
			qm.SetPassPercentage (10);
			qm.SetPassPercentage (200);
			
			// Act
			int result = qm.GetPassPercentage ();
			
			// Assert
			Assert.AreEqual (expectedResult, result);
		}

		
	}
}