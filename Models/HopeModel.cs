using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wish.Models
{
    public class HopeModel
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public string From { get; set; }
        public string Content { get; set; }
        public int BrowserCount { get; set; }
        public int HeartCount { get; set; }
        public string Category { get; set; }
    }

    public enum Plant
    {
        月球 = 0,
        水星= 1, 
        金星= 2,
        地球 = 3,
        火星 = 4,
        木星 = 5,
        土星 = 6,
        天王星 = 7,
        海王星 = 8,
        冥王星 = 9
    }

    public enum HopeCategory
    {
        愛情 = 0,
        健康 = 1,
        親情 = 2,
        友情 = 3,
        人生 = 4,
        職場 = 5,
        學業 = 6,
        財富 = 7,
        事業 = 8
    }
}