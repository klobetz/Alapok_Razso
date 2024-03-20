﻿namespace BlazorApp.Components.Modell
{
    public class PizzaSpec
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal BasePrice { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string GetFormetBasePrice() => BasePrice.ToString("0.00");
    }
}
