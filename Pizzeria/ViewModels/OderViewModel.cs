using System;
using System.Collections.Generic;
using Pizzeria.Models;

namespace Pizzeria.ViewModels
{
    public class OderViewModel
    {
        public int Id { get; set; }

        public List<Product> Products { get; set; }

        public double TotalPrice { get; set; }

        public Customer Customer { get; set; }

        public DateTime DateTime { get; set; }

        public bool IsPaid { get; set; }
    }
}