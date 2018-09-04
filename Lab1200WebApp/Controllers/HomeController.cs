using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using Lab1200WebApp.Models;

namespace Lab1200WebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "基础知识";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "实验指导书";

            return View();
        }

        public IActionResult OnlineAnswer()
        {
            ViewData["Message"] = "在线答题";

            return View();
        }

        public IActionResult Simulation()
        {
            ViewData["Message"] = "模拟仿真";

            return View();
        }

        public IActionResult FeedBack()
        {
            ViewData["Message"] = "反馈";

            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Message"] = "隐私权限";

            return View();
        }

        public IActionResult ExpAppointment()
        {
            ViewData["Message"] = "实验预约";

            return View();
        }

        public IActionResult Login()
        {
            ViewData["Message"] = "登录";

            return View();
        }

        public IActionResult ExpGuide()
        {
            ViewData["Message"] = "实验指导书";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
