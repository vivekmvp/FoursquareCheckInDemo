using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MyFoursquareApp.Models;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFoursquareApp.Controllers
{
    public class Redirect_Callback : Controller
    {
        private readonly IOptions<MyAppSettings> myAppSettings;
        
        public Redirect_Callback(IOptions<MyAppSettings> myAppSettings)
        {
            this.myAppSettings = myAppSettings;
        }

        // GET: /<controller>/
        public async Task<ActionResult> Index(string code)
        {
            var fourSquareClientId = myAppSettings.Value.FoursquareClientId;
            var foursquareClientSecret = myAppSettings.Value.FoursquareClientSecret;
            var foursquareCallbackUrl = myAppSettings.Value.FoursquareCallbackUrl;
            var redirectUrl = string.Format("https://foursquare.com/oauth2/access_token?client_id={0}&client_secret={1}&grant_type=authorization_code&redirect_uri={2}&code={3}",
                fourSquareClientId,
                foursquareClientSecret,
                foursquareCallbackUrl,
                code);

            using (HttpClient httpClient = new HttpClient())
            {
                Task<string> response = httpClient.GetStringAsync(redirectUrl);
                myAppSettings.Value.FoursquareAccessToken = JsonConvert.DeserializeObject<FoursquareOAuthResponse>(response.Result).Access_Token;
            }

            return RedirectToAction("CheckInHistory", "Home");
        }
    }
}
