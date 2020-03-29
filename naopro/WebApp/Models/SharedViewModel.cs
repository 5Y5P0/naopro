using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class SharedViewModel
    {
        IWebHostEnvironment _webHost;

        public SharedViewModel(IOptions<Contact> contact, IOptions<RgpdView> rgpdConfig, IWebHostEnvironment webHost) {
            
            Contact = contact?.Value ?? throw new ArgumentNullException(nameof(contact));
            _webHost = webHost ?? throw new ArgumentNullException(nameof(webHost));

            if (rgpdConfig == null)
                throw new ArgumentNullException(nameof(rgpdConfig));

            Rgpd = rgpdConfig.Value;
            
        }

        public Contact Contact { get; }

        public RgpdView Rgpd { get; }

        public string WebHost { get { return _webHost.WebRootPath; } }

    }
}
