using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MyFoursquareApp.Models;
using MyFoursquareApp.ServiceProvider;
using Newtonsoft.Json;

namespace MyFoursquareApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<MyAppSettings> myAppSettings;
        
        public HomeController(IOptions<MyAppSettings> myAppSettings)
        {
            this.myAppSettings = myAppSettings;
        }

        public async Task<IActionResult> Index()
        {
            var fourSquareClientId = myAppSettings.Value.FoursquareClientId;
            var foursquareCallbackUrl = myAppSettings.Value.FoursquareCallbackUrl;
            var redirectUrl = string.Format("https://foursquare.com/oauth2/authenticate?client_id={0}&response_type=code&redirect_uri={1}", fourSquareClientId, foursquareCallbackUrl);
            return Redirect(redirectUrl);
        }
        
        public async Task<IActionResult> CheckInHistory()
        {
            IFoursquare foursquareService = new FoursquareProvider();
            var response = await foursquareService.GetCheckinHistory(myAppSettings.Value.FoursquareAccessToken);

            if (response != null && response.response.checkins.count > 0)
            {
                return View(response.response.checkins.items);
            }

            return View();
        }
    }
}
