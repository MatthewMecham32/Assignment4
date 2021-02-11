using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    //this is used to store an iEnumerable list of restaurant suggestions
    public class TempStorage
    {
        private static List<RestaurantSuggestions> entries = new List<RestaurantSuggestions>();

        public static IEnumerable<RestaurantSuggestions> Entry => entries;

        public static void AddEntry(RestaurantSuggestions entry)
        {
            entries.Add(entry);
        }
    }
}
