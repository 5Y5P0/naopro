using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    /// <see cref="https://www.frameip.com/plan-numerotation-telephonique/"/>
    public class PhoneNumber : IPhoneNumber
    {
        private const char SHORT_INTERNATIONAL_PREFIX = '+';
        private const string INTERNATIONAL_PREFIX = "00";

        private const string REGIONAL_NUMBER = "33";
        private const char LOCAL_NUMBER = '0';

        private string _number;

        public string Label { get; set; }

        public string Number { get; set; }

    }
}
