﻿using System.ComponentModel.DataAnnotations;

namespace eGameShop.Models
{
    public class DistributionPlatform
    {
        [Key]
        public int Id { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}