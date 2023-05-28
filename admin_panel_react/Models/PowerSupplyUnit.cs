﻿namespace admin_panel_react.Models
{
    public class PowerSupplyUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FormFactor { get; set; }
        public int Power { get; set; }
        public string? ImgUrl { get; set; }


        public double Price { get; set; }
    }
}
