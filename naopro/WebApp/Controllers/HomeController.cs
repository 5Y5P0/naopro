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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOptions<About> _about;
        private readonly SmtpClient _smtpClient;
        public HomeController(ILogger<HomeController> logger, IOptions<About> about, SmtpClient smtpClient)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _about = about ?? throw new ArgumentNullException(nameof(about));
            _smtpClient = smtpClient ?? throw new ArgumentNullException(nameof(smtpClient));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ContactView result = new ContactView
            {
                EnterpriseName = _about.Value.Name,
                EnterprisePhone = _about.Value.Phone
            };

            return View(result);
        }
        public ActionResult<LegalNoticeView> LegalNotice()
        {

            LegalNoticeView result = new LegalNoticeView
            {
                EnterpriseName = _about.Value.Name,
                EnterprisePhone = _about.Value.Phone
            };

            return View(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
