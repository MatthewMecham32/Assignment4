using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class Restaurant
    {
        //create the Restaurant constructor to allow rank to be read only
        public Restaurant(int rank)
        {
            Rank = rank;
        }
        //create the rest of the restaurant class
        [Required]
        public  int Rank { get; }
        [Required]
        public string RestaurantName { get; set; }
        public string? FavoriteDish { get; set; }
        [Required]
        public string Address { get; set; }
        [Phone]

        public string? Phone { get; set; }
        //allows rLink to have a default value
        public string? rLink { get; set; } = "Website Coming Soon!";


        //when this method is called it will create the following restaurant objects
        public static Restaurant[] GetRestaurants()
        {
            Restaurant R1 = new Restaurant(1)
            {
                
                RestaurantName = "Pizza Pie Cafe",
                Address = "2235 N University Pkwy, Provo, UT 84604",
                Phone = "+18013735561",
                rLink = "https://pizzapiecafe.co/"
            };

            Restaurant R2 = new Restaurant(2)
            {
                
                RestaurantName = "Burger Supreme",
                FavoriteDish = "Avocado Burger",
                Address = "1796 N University Pkwy, Provo, UT 84604",
                Phone = "+18013735713",
                
            };
            Restaurant R3 = new Restaurant(3)
            {
                
                RestaurantName = "Red Lobster",
                FavoriteDish = "Maine Lobster Tail",
                Address = "1261 S 800 E, Orem, UT 84097",
                Phone = "+18017243500",
                rLink = "redlobster.com"
            };

            Restaurant R4 = new Restaurant(4)
            {
                
                RestaurantName = "Tucanos",
                Address = "545 E University Pkwy, Orem, UT 84097",
                Phone = "+18012244774",
                rLink = "tucanos.com"
            };
            Restaurant R5 = new Restaurant(5)
            {
                
                RestaurantName = "Sweeto Burrito",
                FavoriteDish = "The Carnivore",
                Address = "1990 N State St, Orem, UT 84057",
                Phone = "+18012251178",
                rLink = "sweetoburrito.com"
            };
            return new Restaurant[] { R1,R2,R3,R4,R5 };
        }

    }
}
