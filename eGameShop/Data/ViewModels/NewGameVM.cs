using eGameShop.Data.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eGameShop.Data.Base;

namespace eGameShop.Models
{
    public class NewGameVM
	{
       

        [Display(Name = "Name of Game")]
        public string Name { get; set; }

		[Display(Name = "Description of Game")]
		public string Description { get; set; }

		[Display(Name = "Image of Game")]
		public string ImageURL { get; set; }

		[Display(Name = "Price")]
		public double Price { get; set; }
        public DateTime StartOfSale { get; set; } //początek daty sprzedaży gry
        public DateTime EndOfSale { get; set; } //koniec daty sprzedaży gry
		[Display(Name = "Quantity")]
		public int Quantity { get; set; } //ilość kopii
		[Display(Name = "Game Category")]
		public GameCategory GameCategory { get; set; }
        //public string Producer { get; set; }

        //Relationships
        public List<int> ProducerId { get; set; }

        //DistributionPlatform
        public int DistributionPlatformId { get; set; }
       // [ForeignKey("DistributionPlatformId")]
       // public DistributionPlatform DistributionPlatform { get; set; } //nazwa platformy na którą jest grą (Steam , GOG, Blizzard)

        //Platform
        public int PlatformId { get; set; }
      //  [ForeignKey("PlatformId")]
      //  public Platform Platform { get; set; } //nazwa platformy na jaką jest grą (PC, XBOX, PS5)

        //public Platform Platform { get; set; } 

        ////Producer
        public int PublisherId { get; set; }
     //   [ForeignKey("PublisherId")]
     //   public Publisher Publisher { get; set; } //producent gry


    
    }
}
