using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class AppInfoViewModel
    {
        private readonly About _about;

        public AppInfoViewModel(IOptions<About> about) {
            _about = about?.Value ?? throw new ArgumentNullException(nameof(about));
        }

        public string Name { get { return _about.Name; } }
    }
}
