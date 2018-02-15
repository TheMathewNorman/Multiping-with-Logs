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
        /// Validates a Hostname
        /// </summary>
        /// <param name="input">User input from the "Add" section on the settings form.</param>
        /// <returns>True or false based on the validity of the input.</returns>
        private bool validateHostname(string input)
        {
            var illegalCharactersPattern = @"[^A-z0-9-]"; // Matches only legal hostname chars
            
            
            bool isValidHostname = false;

            // Validate that no illegal characters are contained within the input.
            isValidHostname = !Regex.IsMatch(input, illegalCharactersPattern);

            return isValidHostname;
        }

        /// <summary>
        /// Validates an IP Address
        /// </summary>
        /// <param name="input">User input fromt he "Add" section on the settings form.</param>
        /// <returns>True or false based on the validity of the input.</returns>
        private bool validateIPAddress(string input)
        {
            // Validate IP Addresses using System.Net.IPAddress
            IPAddress address;
            return IPAddress.TryParse(input, out address);
        }


        /// <summary>
        /// Retruns a boolean based on the validity of a user inputted address.
        /// </summary>
        /// <param name="input">User input fromt he "Add" section on the settings form.</param>
        /// <param name="address">IP Address or Hostname where valid, empty string where invalid.</param>
        /// <returns>True or false based on the validity of the input.</returns>
        public bool TryParse(string input, out string address)
        {
            bool isValidHostnameOrIP = false;


            address = "";
            return isValidHostnameOrIP;
        }
    }
}
