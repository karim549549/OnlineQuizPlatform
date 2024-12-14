using OnlineQuizPlatform.Database;
using OnlineQuizPlatform.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizPlatform.Helpers
{
    public static class DataSeeder
    {
        public static void SeedQuestions(ApplicationDbContext dbContext)
        {
            var questions = new List<Question>
            {
                new Question
                {
                    Text = "What is the capital of France?",
                    Options = new List<string> { "Paris", "London", "Berlin", "Madrid" },
                    CorrectAnswerIndex = 0,
                    Score = 10
                },
                new Question
                {
                    Text = "What is 2 + 2?",
                    Options = new List<string> { "3", "4", "5", "6" },
                    CorrectAnswerIndex = 1,
                    Score = 5
                },
                new Question
                {
                    Text = "Who wrote 'Romeo and Juliet'?",
                    Options = new List<string> { "William Shakespeare", "Charles Dickens", "Jane Austen", "Mark Twain" },
                    CorrectAnswerIndex = 0,
                    Score = 15
                },
                new Question
                {
                    Text = "What is the largest planet in our solar system?",
                    Options = new List<string> { "Earth", "Mars", "Jupiter", "Saturn" },
                    CorrectAnswerIndex = 2,
                    Score = 10
                },
                new Question
                {
                    Text = "What is the chemical symbol for water?",
                    Options = new List<string> { "H2O", "O2", "CO2", "HO" },
                    CorrectAnswerIndex = 0,
                    Score = 5
                },
                new Question
                {
                    Text = "Who painted the Mona Lisa?",
                    Options = new List<string> { "Vincent van Gogh", "Leonardo da Vinci", "Pablo Picasso", "Claude Monet" },
                    CorrectAnswerIndex = 1,
                    Score = 15
                },
                new Question
                {
                    Text = "What is the smallest prime number?",
                    Options = new List<string> { "0", "1", "2", "3" },
                    CorrectAnswerIndex = 2,
                    Score = 5
                },
                new Question
                {
                    Text = "What is the boiling point of water at sea level?",
                    Options = new List<string> { "100°C", "90°C", "80°C", "110°C" },
                    CorrectAnswerIndex = 0,
                    Score = 10
                },
                new Question
                {
                    Text = "What is the square root of 64?",
                    Options = new List<string> { "6", "7", "8", "9" },
                    CorrectAnswerIndex = 2,
                    Score = 5
                },
                new Question
                {
                    Text = "Who was the first President of the United States?",
                    Options = new List<string> { "Abraham Lincoln", "George Washington", "Thomas Jefferson", "John Adams" },
                    CorrectAnswerIndex = 1,
                    Score = 15
                }
            };

            dbContext.Questions.AddRange(questions);
            dbContext.SaveChanges();
        }
    }
}
