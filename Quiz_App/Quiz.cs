using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Quiz_App
{
    internal class Quiz
    {
        private int quizID;
        private String title;
        private String description;
        //private Category quizCategory; Relies on Category class - not implemented yet
        private List<Question> questions;
        private DateTime date;
        //private User[] competitors; Relies on user class - not implemented yet

        public int QuizID { get { return quizID; }}
        public String Title { get { return title; } set { title = value; } }
        public String Description { get { return description; } set { description = value; } }
        //public Category QuizCategory { get { return quizCategory; } set { quizCategory = value; } } 
        public List<Question> Questions { get { return questions; } set { questions = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
        //public User[] Competitors { get { return competitors;  } set { competitors = value; } }

        public Quiz(String title, String description, /*Category category,*/ List<Question> questions, DateTime date/*, User[] competitors*/)
        {
            quizID++;
            Title = title;
            Description = description;
            /*QuizCategory = category;*/
            Questions = questions;
            Date = date;
            /*Competitors = competitors;*/
        }

        public void DisplayQuiz()
        {
            Console.WriteLine("Title: " + Title);
            foreach (Question question in questions) { 
                question.DisplayQuestion();
                Console.WriteLine("");
            }
        }

        public void SaveQuiz()
        {
            string filePath = "questions.csv";
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    if (!File.Exists(filePath))
                    {
                        sw.WriteLine("QuizID,Title,Description,QuestionID,QuestionText,QuestionOptions,QuestionAnswer,QuestionDifficulty,Date"); //Needs updated for category and users
                    }
                    foreach (Question q in questions)
                    {
                        string joinOptions = string.Join("|", q.Options);
                        string line = $"{QuizID}," +
                        $"{CsvEscape(Title)}," + $"{CsvEscape(Description)}," + $"{q.QuestionID}," + $"{CsvEscape(q.QuestionText)}," +
                        $"{CsvEscape(joinOptions)}," + $"{q.Answer}," + $"{CsvEscape(q.Difficulty)}," + $"{Date:yyyy-MM-dd}";
                        sw.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error saving quiz: " + e.Message);
            }
        }

        private string CsvEscape(string value)
        {
            if (value == null) return "";

            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
            {
                value = value.Replace("\"", "\"\"");
                return $"\"{value}\"";
            }

            return value;
        }

        public void CreateQuestion()
        {
            List<string> options = new List<string>();
            Console.WriteLine("Enter the text of the question: ");
            string text = Console.ReadLine();
            Console.WriteLine("Enter the possible answers, press 0 to finish: ");
            string input = " ";
            do
            {
                input = Console.ReadLine();
                options.Add(input);
            } while (input != "0");
            Console.WriteLine("Please enter the index of the correct input (Starting at 0 instead of 1): ");
            int answer =  Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter the difficulty of the question (Easy, Medium, Hard): ");
            string difficulty = Console.ReadLine();
            Questions.Add(new Question(text, options, answer, difficulty));
        }

        public void UpdateQuestion(int questionID)
        {
            int index = 0;
            for(index, Questions.Count - 1, index++)
            {
                if (Questions[index].QuestionID == questionID)
                {
                    List<string> options = new List<string>();
                    Console.WriteLine("Enter the text of the question: ");
                    string text = Console.ReadLine();
                    Console.WriteLine("Enter the possible answers, press 0 to finish: ");
                    string input = " ";
                    do
                    {
                        input = Console.ReadLine();
                        options.Add(input);
                    } while (input != "0");
                    Console.WriteLine("Please enter the index of the correct input (Starting at 0 instead of 1): ");
                    int answer = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Please enter the difficulty of the question (Easy, Medium, Hard): ");
                    string difficulty = Console.ReadLine();
                    Questions[index].UpdateQuestion(text, options, answer, difficulty);
                }
            }
        }

        public void RemoveQuestion(int questionID)
        {
            int index = 0;
            for (index, Questions.Count - 1, index++)
            {
                if (Questions[index].QuestionID == questionID)
                {
                    Questions.RemoveAt(index);
                    return;
                }
            }
        }
    }
}
