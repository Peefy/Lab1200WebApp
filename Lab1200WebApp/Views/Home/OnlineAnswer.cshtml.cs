using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab1200WebApp.Views.Home
{
    public class OnlineAnswerModel : PageModel
    {
        public void OnGet()
        {

        }

        public string Questions { get; set; } = "";

        public List<string> Answers { get; set; }

        public string RightAnswer { get; set; } = "";

        public int RightAnswerIndex = 0;

        public int DefaultAnswerIndex = 0;

        public OnlineAnswerModel()
        {
            Answers = new List<string>();
        }

    }
}