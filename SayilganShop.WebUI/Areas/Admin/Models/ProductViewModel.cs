﻿namespace SayilganShop.WebUI.Areas.Admin.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public int UnitInStock { get; set; }
        public decimal? UnitPrice { get; set; }
        public string ImagePath { get; set; }
    }
}
