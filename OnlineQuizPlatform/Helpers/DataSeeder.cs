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
                },
                new Question
                {
                    Text = "Which gas do plants absorb from the atmosphere?",
                    Options = new List<string> { "Oxygen", "Nitrogen", "Carbon Dioxide", "Hydrogen" },
                    CorrectAnswerIndex = 2,
                    Score = 10
                },
                new Question
                {
                    Text = "What is the capital city of Japan?",
                    Options = new List<string> { "Beijing", "Seoul", "Bangkok", "Tokyo" },
                    CorrectAnswerIndex = 3,
                    Score = 10
                },
                new Question
                {
                    Text = "How many continents are there on Earth?",
                    Options = new List<string> { "5", "6", "7", "8" },
                    CorrectAnswerIndex = 2,
                    Score = 5
                },
                new Question
                {
                    Text = "Who developed the theory of relativity?",
                    Options = new List<string> { "Isaac Newton", "Albert Einstein", "Nikola Tesla", "Galileo Galilei" },
                    CorrectAnswerIndex = 1,
                    Score = 15
                },
                new Question
                {
                    Text = "What is the currency of the United Kingdom?",
                    Options = new List<string> { "Dollar", "Euro", "Pound Sterling", "Yen" },
                    CorrectAnswerIndex = 2,
                    Score = 10
                },
                new Question
                {
                    Text = "What is the main ingredient in guacamole?",
                    Options = new List<string> { "Tomato", "Avocado", "Potato", "Onion" },
                    CorrectAnswerIndex = 1,
                    Score = 5
                },
                new Question
                {
                    Text = "Which ocean is the largest?",
                    Options = new List<string> { "Atlantic Ocean", "Indian Ocean", "Arctic Ocean", "Pacific Ocean" },
                    CorrectAnswerIndex = 3,
                    Score = 10
                },
                new Question
                {
                    Text = "Who invented the telephone?",
                    Options = new List<string> { "Thomas Edison", "Alexander Graham Bell", "Benjamin Franklin", "Nikola Tesla" },
                    CorrectAnswerIndex = 1,
                    Score = 15
                },
                new Question
                {
                    Text = "What is the national animal of Australia?",
                    Options = new List<string> { "Kangaroo", "Koala", "Emu", "Platypus" },
                    CorrectAnswerIndex = 0,
                    Score = 5
                },
                new Question
                {
                    Text = "How many players are there in a standard soccer team?",
                    Options = new List<string> { "9", "10", "11", "12" },
                    CorrectAnswerIndex = 2,
                    Score = 5
                }


            };

            dbContext.Questions.AddRange(questions);
            dbContext.SaveChanges();
        }
    }
}
