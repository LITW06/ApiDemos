using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ApiDemos.HebCal
{
    public class HebrewDateConversionResult
    {
        [JsonProperty("hy")]
        public int Year { get; set; }

        [JsonProperty("hm")]
        public string Month { get; set; }

        [JsonProperty("hd")]
        public int Day { get; set; }

        public string Hebrew { get; set; }

        public IEnumerable<string> Events { get; set; }
    }
}
