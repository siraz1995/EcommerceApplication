﻿namespace EcommerceApplication.Models
{
    public class Card
    {
        public int Id { get; set; }
        public int  UserId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
