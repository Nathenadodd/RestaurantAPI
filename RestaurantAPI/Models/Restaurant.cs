
using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Models
{
    //Restaurant Entity
    //Entity is just a business object we're storing in the database
    public class Restaurant
    {
       [Key]//Once key is in nothing else is required.
        public int RestaurantId { get; set; } //keeps adding plus 1 for each item. If one deleted there will be a gap. Starts at 1.
        //restaurant is now  an int
        [Required]//these attributes are only valid for the first item below it
        public string Name { get; set; }
        public string Hours { get; set; }
        public string Address { get; set; }
        [Required]
        public string Cuisine { get; set; }

    }
}