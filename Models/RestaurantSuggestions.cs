using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    //this class creates the suggestions
    public class RestaurantSuggestions
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        public string? FavoriteDish { get; set; } = "It's all tasty!";

        //uses a regular expression to make sure phone numbers are correctly input
        //accepts 123-456-7890 or 1234567890
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
           ErrorMessage = "Entered phone format is not valid.")]
        public string? Phone { get; set; }

    }
}
