using NUnit.Framework;

namespace UnityTest
{
    [TestFixture]
    internal class A_Basics
    {
        [Test]
        public void ZeroTotalAttemptedWhenCreated()
        {
            // Arrange
            QuizManager qm = new QuizManager();
            int expectedResult = 0;

            // Act
            int result = qm.GetTotalQuestionsAttempted();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ZeroTotalCorrectWhenCreated()
        {
            // Arrange
            QuizManager qm = new QuizManager();
            int expectedResult = 0;

            // Act
            int result = qm.GetTotalQuestionsCorrect();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ZeroTotalWrongWhenCreated()
        {
            // Arrange
            QuizManager qm = new QuizManager();
            int expectedResult = 0;

            // Act
            int result = qm.GetTotalQuestionsWrong();

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }

}