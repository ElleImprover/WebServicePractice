using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using APIPractice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using APIPractice.ViewModels;
using System.Net.Http;
using System.Xml.Serialization;

namespace APIPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private APIService _service;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _service = new APIService();
        }

        public async Task<IActionResult> Index()
        {
            APIViewModel aPIViewModel = new APIViewModel();
            aPIViewModel.RandomNumber = await _service.getRandomNumberAsync();
            aPIViewModel.ChucKNorris = await _service.getChuckNorrisJoke();
            var sR = await _service.getSeleucidsAsync();
            aPIViewModel.seleucids = sR.Seleucids;

            return View(aPIViewModel);
        }

        public async Task<IActionResult> Teacher()
        {
            TeacherViewModel teacher = new TeacherViewModel();
            teacher.Teacher = await _service.GetATeacher();
            var tL = await _service.GetTeachers();
            teacher.TeacherList = tL;
            return View(teacher);
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
