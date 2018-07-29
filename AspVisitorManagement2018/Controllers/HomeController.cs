using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspVisitorManagement2018.Models;
using AspVisitorManagement2018.Services;
using Microsoft.AspNetCore.Hosting;

namespace AspVisitorManagement2018.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITextFileOperations _textFileOperations;

        public HomeController(ITextFileOperations textFileOperations)
        {
            _textFileOperations = textFileOperations;
        }

        public IActionResult Index()
        {
            ViewBag.Welcome = "Welcome to the Visitor Management System";
            ViewData["AnotherWelcome"] = "Please enter your name";

            //======= Conditions of Acceptance
            //Gets or sets the absolute path to the directory that contains the web-servable application content files.
            ViewData["Conditions"] = _textFileOperations.LoadConditionsForAcceptanceText();

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}