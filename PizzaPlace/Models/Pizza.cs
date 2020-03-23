using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Models
{

    public enum Spiciness
    {
        None,
        Spicy,
        Hot
    }
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Spiciness Spiciness { get; set; }

        public Pizza(int id, string name, decimal price, Spiciness spiciness)
        {
            Id = id;
            Name = name;
            Price = price;
            Spiciness = spiciness;
        }
    }
}
