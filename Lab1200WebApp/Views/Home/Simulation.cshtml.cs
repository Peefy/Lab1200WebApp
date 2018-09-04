using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab1200WebApp.Views.Home
{
    public class SimulationModel : PageModel
    {
        public string Message { get; private set; } = "PageModel in C#";

        public void OnGet()
        {
            Message += $" Server time is { DateTime.Now }";
        }

        public string SubTitle { get; set; } = "dugu";

        public List<string> Sections { get; set; }

        public SimulationModel()
        {
            Sections = new List<string>
            {
                "Section one",
                "Section two",
                "Section three",
            };
        }

    }
}