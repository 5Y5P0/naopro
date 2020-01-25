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
        public const char PREFIX = 'v';

        public string Version {

            get {
                string versionNumber = Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
                return $"{PREFIX}{versionNumber}";
            }

        }

        public string FullVersion {

            get {
                string versionNumber = typeof(Startup).Assembly.GetName().Version.ToString();
                return $"{PREFIX}{versionNumber}";
            }

        }

        public string PublicVersion {

            get {
                int index = Version.IndexOf(VERSION_SEPARATOR, Version.IndexOf(VERSION_SEPARATOR) + 1);
                return Version.Substring(0, index);
            }

        }
    }
}
