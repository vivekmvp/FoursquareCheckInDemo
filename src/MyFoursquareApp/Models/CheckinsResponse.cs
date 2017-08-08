using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFoursquareApp.Models
{
    
    public class Meta
    {
        public int code { get; set; }
        public string requestId { get; set; }
    }

    public class Item
    {
        public int unreadCount { get; set; }
    }

    public class Notification
    {
        public string type { get; set; }
        public Item item { get; set; }
    }

    public class Contact
    {
        public string phone { get; set; }
        public string formattedPhone { get; set; }
        public string twitter { get; set; }
        public string facebook { get; set; }
        public string facebookUsername { get; set; }
        public string facebookName { get; set; }
    }

    public class LabeledLatLng
    {
        public string label { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
    }

    public class Location
    {
        public string address { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public List<LabeledLatLng> labeledLatLngs { get; set; }
        public string postalCode { get; set; }
        public string cc { get; set; }
        public string neighborhood { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public List<string> formattedAddress { get; set; }
    }

    public class Icon
    {
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Category
    {
        public string id { get; set; }
        public string name { get; set; }
        public string pluralName { get; set; }
        public string shortName { get; set; }
        public Icon icon { get; set; }
        public bool primary { get; set; }
    }

    public class Stats
    {
        public int checkinsCount { get; set; }
        public int usersCount { get; set; }
        public int tipCount { get; set; }
    }

    public class Menu
    {
        public string type { get; set; }
        public string label { get; set; }
        public string anchor { get; set; }
        public string url { get; set; }
        public string mobileUrl { get; set; }
        public string externalUrl { get; set; }
    }

    public class BeenHere
    {
        public int lastCheckinExpiredAt { get; set; }
    }

    public class VenuePage
    {
        public string id { get; set; }
    }

    public class Venue
    {
        public string id { get; set; }
        public string name { get; set; }
        public Contact contact { get; set; }
        public Location location { get; set; }
        public List<Category> categories { get; set; }
        public bool verified { get; set; }
        public Stats stats { get; set; }
        public string url { get; set; }
        public bool hasMenu { get; set; }
        public Menu menu { get; set; }
        public bool allowMenuUrlEdit { get; set; }
        public BeenHere beenHere { get; set; }
        public VenuePage venuePage { get; set; }
        public string storeId { get; set; }
        public bool? venueRatingBlacklisted { get; set; }
    }

    public class Likes
    {
        public int count { get; set; }
        public List<object> groups { get; set; }
    }

    public class Photos
    {
        public int count { get; set; }
        public List<object> items { get; set; }
    }

    public class Posts
    {
        public int count { get; set; }
        public int textCount { get; set; }
    }

    public class Comments
    {
        public int count { get; set; }
    }

    public class Source
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Item2
    {
        public string id { get; set; }
        public int createdAt { get; set; }
        public string type { get; set; }
        public bool @private { get; set; }
        public string visibility { get; set; }
        public int timeZoneOffset { get; set; }
        public Venue venue { get; set; }
        public Likes likes { get; set; }
        public bool like { get; set; }
        public bool isMayor { get; set; }
        public Photos photos { get; set; }
        public Posts posts { get; set; }
        public Comments comments { get; set; }
        public Source source { get; set; }
    }

    public class Checkins
    {
        public int count { get; set; }
        public List<Item2> items { get; set; }
    }

    public class Response
    {
        public Checkins checkins { get; set; }
    }

    public class CheckinsResponse
    {
        public Meta meta { get; set; }
        public List<Notification> notifications { get; set; }
        public Response response { get; set; }
    }
}
