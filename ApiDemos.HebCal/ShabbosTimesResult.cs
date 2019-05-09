using System.Collections.Generic;

namespace ApiDemos.HebCal
{
    public class ShabbosTimesResult
    {
        public string Title { get; set; }
        public Location Location { get; set; }
        public IEnumerable<Event> Items { get; set; }
    }
}