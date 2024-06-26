﻿namespace Hattfabriken.Models
{
    public class HatViewModel
    {
        public int HatId { get; set; }  
        public string HatName { get; set; }
        public string MaterialName { get; set; }
        public Material Material { get; set; }
        public string Description { get; set; }
        public double TotalPrice { get; set; }
        public string? SpecialEffects { get; set; }
        public int OuterMeasurement { get; set; }
        public int Quantity { get; set; }
    }
}
