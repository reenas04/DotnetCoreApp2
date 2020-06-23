using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DotnetCoreApp2.Models;

namespace DotnetCoreApp2.Controllers
{
    public class PagesController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public PagesController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult CandidateList()
        {
            return View();
        }

        public IActionResult JobList()
        {
            return View();
        }
    }
}