using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class NoticeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOptions<Contact> _about;

        public NoticeController(ILogger<HomeController> logger, IOptions<Contact> about)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _about = about ?? throw new ArgumentNullException(nameof(about));

        }

        public ActionResult Cookies()
        {
            return View();
        }

    }
}
