using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MyFoursquareApp.Models;
using Newtonsoft.Json;

namespace MyFoursquareApp.ServiceProvider
{
    public class FoursquareProvider : IFoursquare
    {
        public async Task<CheckinsResponse> GetCheckinHistory(string access_token)
        {
            var baseCheckInUrl = "https://api.foursquare.com/v2/users/self/checkins";
            var checkInResponse = new CheckinsResponse();
            var checkInApiUrl = string.Format("{0}?oauth_token={1}&v=20170610",baseCheckInUrl, access_token);

            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(checkInApiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var apiResponse = await response.Content.ReadAsAsync<Object>();
                    checkInResponse = JsonConvert.DeserializeObject<CheckinsResponse>(apiResponse.ToString());
                }
            }

            return checkInResponse;
        }
    }
}
