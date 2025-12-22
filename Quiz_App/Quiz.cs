using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_App
{
    internal class Quiz
    {
        private int quizID;
        private String title;
        private String description;
        //private Category category; Relies on Category class - not implemented yet
        private Question[] questions;
        private DateTime date;
        //private User[] competitors; Relies on user class - not implemented yet

        public int QuizID { get { return quizID; }}
        public String Title { get { return title; } set { title = value; } }
        public String Description { get { return description; } set { description = value; } }
        //public Category Category { get { return category; } set { category = value; } } 
        public Question[] Questions { get { return questions; } set { questions = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
        //public User[] Competitors { get { return competitors;  } set { competitors = value; } }
    }
}
