using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ping_with_Logs
{
    class HostnameOrIP
    {
        /// <summary>
        /// Retruns a boolean based on the validity of a user inputted address.
        /// </summary>
        /// <param name="input">String to be validated</param>
        /// <param name="address">IP Address or Hostname where valid, empty string where invalid.</param>
        /// <returns>True or false based on the validity of the input.</returns>
        public bool TryParse(string input, out string address)
        {
            // Valid IP address pattern
            var IPAddressPattern = @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";
            // Valid hostname pattern
            var HostnamePattern = @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";

            bool isValidHostnameOrIP = false;
            address = "";

            // Validate input against regex patterns for ip addresses and hostnames.
            if (Regex.IsMatch(input, IPAddressPattern) || Regex.IsMatch(input, HostnamePattern))
            {
                isValidHostnameOrIP = true;
                address = input;
            }

            return isValidHostnameOrIP;
            
        }
    }
}
