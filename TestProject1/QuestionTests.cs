using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz_App;

namespace Quiz_App.Tests
{
    [TestClass]

    public class QuestionTests
    {
        [TestMethod]
        public void TestQuestionConstructor()
        {
            string questionText = "What is 2 + 2?";
            var options = new List<string> { "3", "4", "5", "6" };
            int answer = 2;
            string difficulty = "Easy";

            Question question = new Question(questionText, options, answer, difficulty);

            Assert.AreEqual(questionText, question.QuestionText);
            CollectionAssert.AreEqual(options, question.Options);
            Assert.AreEqual(answer, question.Answer);
            Assert.AreEqual(difficulty, question.Difficulty);
        }

        [TestMethod]
        public void TestUpdateQuestion()
        {
            var options = new List<string> { "3", "4", "5", "6" };
            Question question = new Question("What is 2 + 2?", options, 2, "Easy");

            string newText = "What is 3 + 3?";
            var newOptions = new List<string> { "5", "6", "7", "8" };
            int newAnswer = 2;
            string newDifficulty = "Medium";

            question.UpdateQuestion(newText, newOptions, newAnswer, newDifficulty);

            Assert.AreEqual(newText, question.QuestionText);
            CollectionAssert.AreEqual(newOptions, question.Options);
            Assert.AreEqual(newAnswer, question.Answer);
            Assert.AreEqual(newDifficulty, question.Difficulty);
        }
    }
}