using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public interface IAppVersionService
    {
        string Version { get; }
    }

}
