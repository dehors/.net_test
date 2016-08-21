using System;
using System.ComponentModel.DataAnnotations;

namespace Full_tutorial.Models
{
    public class Product
    {
         /*Esta es la primary key se deben de importar using "System.ComponentModel.DataAnnotations;" , se puede sacar con el "ctrl ."*/
        public int ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime LastBuy { get; set; }
        public float Stock { get; set; }
        public string Remarks { get; set; }
    }
}