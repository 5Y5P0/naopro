using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class SharedViewModel
    {
        public SharedViewModel(IOptions<Contact> contact, CookiesView rgpd) {
            Contact = contact?.Value ?? throw new ArgumentNullException(nameof(contact));
            Rgpd = rgpd ?? throw new ArgumentNullException(nameof(rgpd));
        }

        public Contact Contact { get; }

        public CookiesView Rgpd { get; }
    }
}
