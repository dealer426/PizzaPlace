﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaPlace.Models
{
    public class Basket
    {
        public Customer Customer { get; set; } = new Customer();
        public List<int> Orders { get; set; } = new List<int>();
        public bool HasPaid { get; set; } = false;

        public Basket()
        {

        }

        public void Add(int pizzaId)
        {
            Orders.Add(pizzaId);
        }

    }
}
