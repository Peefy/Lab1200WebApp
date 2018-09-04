using System.Collections.Generic;

namespace Lab1200WebApp.Models
{
    public class QuestionViewModel
    {
        public string Questions { get; set; } = "123";

        public List<string> Answers { get; set; }

        public string RightAnswer { get; set; } = "";

        public int RightAnswerIndex = 0;

        public int DefaultAnswerIndex = 0;

        public QuestionViewModel()
        {
            Answers = new List<string>();
        }

    }

}