using System.Collections.Generic;

namespace Lab1200WebApp.Models
{

    public class SimulationViewModel
    {

        public string VideoUrl { get; set; } = "~/videos/1_1.mp4";

        public string Title { get; set; } = "";

        public List<string> SubTitles { get; set; }

        public List<string> VideoUrls { get; set; }

        public SimulationViewModel()
        {

        }
    }

}