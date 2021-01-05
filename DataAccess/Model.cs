using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PizzaApiManager.DataAccess
{
    public class PizzaSize
    {
        public int ID { get; set; }

        [MaxLength(150)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [JsonIgnore]
        public List<Pizza> Pizzas { get; set; }
    }


    public class Pizza
    {
        public int ID { get; set; }

        [MaxLength(150)]
        [Required]
        public string Name { get; set; } = string.Empty;

        public PizzaSize Size { get; set; }

        public int PersonalRating { get; set; }
    }
}
