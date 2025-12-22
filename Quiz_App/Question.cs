using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_App
{
    internal class Question
    {
        private int questionID;
        private string questionText;
        private string[] options;
        private int answer;
        private string difficulty;

        public int QuestionID { get { return questionID; } set { questionID = value; } }
        public String QuestionText { get { return questionText; } set { questionText = value; } }
        public string[] Options { get { return options; } set { options = value; } }
        public int Answer { get { return answer; } set { answer = value; } }
        public string Difficulty { get { return difficulty; } set { difficulty = value; } }

        public Question (int questionID, string questionText, string[] options, 
                        int answer, string difficulty) 
        {
            QuestionID = questionID;
            QuestionText = questionText;
            Options = options;
            Answer = answer;
            Difficulty = difficulty;
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(QuestionText);
            for (int i = 0; i < Options.Length; i++)
            {
                Console.WriteLine((i+1)+"- "+Options[i]);
            }
        }

        public void UpdateQuestion(String newText, String[] newOptions, int newAnswer, String newDifficulty)
        {
            QuestionText = newText;
            Options = newOptions;
            Answer = newAnswer;
            Difficulty = newDifficulty;
        }
    }
}
