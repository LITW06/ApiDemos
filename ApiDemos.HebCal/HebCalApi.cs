using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace ApiDemos.HebCal
{
    public class HebCalApi
    {
        public HebrewDateConversionResult ConvertToHebrew(DateTime date)
        {
            var client = new HttpClient();
            string url = $"https://www.hebcal.com/converter/?cfg=json&gy={date.Year}&gm={date.Month}&gd={date.Day}&g2h=1";
            string json = client.GetStringAsync(url).Result;
            var result = JsonConvert.DeserializeObject<HebrewDateConversionResult>(json);
            return result;
        }

        public ShabbosTimesResult GetUpcomingShabbosTimes(string zip)
        {
            var client = new HttpClient();
            string url = $"https://www.hebcal.com/shabbat/?cfg=json&zip=${zip}";
            string json = client.GetStringAsync(url).Result;
            var result = JsonConvert.DeserializeObject<ShabbosTimesResult>(json);
            return result;
        }
    }
}