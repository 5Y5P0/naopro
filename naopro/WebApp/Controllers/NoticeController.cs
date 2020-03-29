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
        private readonly SmtpClient _smtp;
        private readonly RgpdView _rgpd;

        public NoticeController(ILogger<HomeController> logger, IOptions<Contact> about, SmtpClient smtpClient, IOptions<RgpdView> rgpdConfig)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _about = about ?? throw new ArgumentNullException(nameof(about));
            _smtp = smtpClient ?? throw new ArgumentNullException(nameof(smtpClient));

            if (rgpdConfig == null)
                throw new ArgumentNullException(nameof(rgpdConfig));

            _rgpd = rgpdConfig.Value;
        }

        public ActionResult Cookies()
        {
            return View(_rgpd);
        }

        public ActionResult Rgpd()
        {
            return View(_rgpd);
        }

    }
}
