using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using naopro.Models;

namespace naopro.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration _iconfiguration;
        public HomeController(IConfiguration iconfiguration)
        {
            _iconfiguration = iconfiguration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            HomeViewModel model = new HomeViewModel() { GooleApi = _iconfiguration.GetSection("GoogleApi").Value };
            return View(model);
        }
        public IActionResult LegalNotice()
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
