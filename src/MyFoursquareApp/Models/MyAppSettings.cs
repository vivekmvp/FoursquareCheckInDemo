using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFoursquareApp.Models
{
    public class MyAppSettings 
    {
        public string FoursquareClientId { get; set; }
        public string FoursquareClientSecret { get; set; }
        public string FoursquareCallbackUrl { get; set; }
        public string FoursquareAccessToken { get; set; }
    }
}
