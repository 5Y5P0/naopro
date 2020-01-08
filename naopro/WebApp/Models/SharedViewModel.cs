using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class SharedViewModel
    {
        private readonly Contact _contact;

        public SharedViewModel(IOptions<Contact> contact) {
            _contact = contact?.Value ?? throw new ArgumentNullException(nameof(contact));
        }

        public string Name { get { return _contact.Name; } }
    }
}
