﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Models
{
    public class Menu
    {

        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

        public Pizza GetPizza(int id)
            => Pizzas.SingleOrDefault(pizza => pizza.Id == id);

    }
}
