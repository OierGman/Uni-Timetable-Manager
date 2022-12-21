namespace TMUnitTest
{
    public class APITests
    {
        [Fact]
        public async Task TestMain()
        {
            // Arrange
            // Set the seed value 
            string seed1 = "amount=10"; 

            // Act
            await TMEngine.GetQuiz(seed1);

            // Assert
            Assert.False(QuizJson.roots.Count != 10);
        }

        [Fact]
        public async Task TestDifficulty()
        {
            // Arrange
            // Set the seed value 
            string seed1 = "amount=10&difficulty=hard";

            // Act
            await TMEngine.GetQuiz(seed1);

            // Assert
            Assert.True(QuizJson.roots[0].difficulty == "hard");
        }
    }
}
