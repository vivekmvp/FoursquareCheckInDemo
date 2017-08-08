using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFoursquareApp.Models;

namespace MyFoursquareApp.ServiceProvider
{
    public interface IFoursquare
    {
        Task<CheckinsResponse> GetCheckinHistory(string access_token);
    }
}
