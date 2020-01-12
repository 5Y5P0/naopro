using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class AppVersionService : IAppVersionService
    {
        public const char VERSION_SEPARATOR = '.';

        public string Version => Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;

        public string FullVersion => typeof(Startup).Assembly.GetName().Version.ToString();

        public string PublicVersion {

            get {
                int index = Version.IndexOf(VERSION_SEPARATOR, Version.IndexOf(VERSION_SEPARATOR) + 1);
                return $"v{Version.Substring(0, index)}";
            }
        }
    }
}
