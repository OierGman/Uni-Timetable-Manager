namespace TMUnitTest
{
    public class QuizTest
    {
        [Theory]
        [InlineData("44")]
        [InlineData("the heart")]
        [InlineData("a very large number")]
        [InlineData("")]
        [InlineData("studying software engineering")]
        [InlineData("55")]
        public void TestMain(string x)
        {
            // Arrange
            var wrong_ans3 = new List<string>()
            {
                "55"
            };
            var correct_ans3 = new List<string>()
            {
                "42"
            };
            Questions q4 = new Questions("Short Answer", "What is the meaning of life?", correct_ans3, wrong_ans3, 42);

            string userIntput = x;

            // Act
            bool correctAns = x == q4.Correct_Ans[0];

            // Assert
            Assert.False(correctAns);
        }
    }
}
