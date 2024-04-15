﻿namespace Hattfabriken.Models

{
    public class AddHatViewModel
    {
        public string HatName { get; set; }
        //[ForeignKey("Material")]
        public string MaterialName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string SpecialEffects { get; set; }
        public int OuterMeasurement { get; set; }
    }
}