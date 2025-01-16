using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Common
{
    public class ApiSettings
    {
        /// <summary>
        /// Gets or sets the base URL for the API.
        /// </summary>
        public string BaseUrl { get; set; }

        /// <summary>
        /// Gets or sets the domain for the API.
        /// </summary>
        public string ApiDomain { get; set; }
    }
}