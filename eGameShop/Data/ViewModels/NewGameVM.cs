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

        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required!")]
        [Display(Description = "Game name")]
        public string Name { get; set; }

		[Display(Description = "Game description")]
        [Required(ErrorMessage = "Description is required!")]
        public string Description { get; set; }

		[Display(Description = "Image of Game")]
        [Required(ErrorMessage = "Image is required!")]
        public string ImageURL { get; set; }

		[Display(Description = "Price of Game")]
        [Required(ErrorMessage = "Price is required!")]
        public double Price { get; set; }

        [Display(Description = "Start Of Sale the Game")]
        [Required(ErrorMessage = "Date is required!")]
        public DateTime StartOfSale { get; set; } //początek daty sprzedaży gry

        [Display(Description = "End Of Sale the Game")]
        [Required(ErrorMessage = "Date is required!")]
        public DateTime EndOfSale { get; set; } //koniec daty sprzedaży gry

        [Display(Description = "Quantity of the Game")]
        [Required(ErrorMessage = "Quantity is required!")]
        public int Quantity { get; set; } //ilość kopii

        [Display(Description = "Select a Category")]
        [Required(ErrorMessage = "Game Category is required!")]
        public GameCategory GameCategory { get; set; }
        //public string Producer { get; set; }

        //Relationships
        [Display(Description = "Select Producer(s)")]
        [Required(ErrorMessage = "Producer(s) is(are) required!")]
        public List<int> ProducerIds { get; set; }

        //DistributionPlatform
        [Display(Description = "Select Distribution Platform")]
        [Required(ErrorMessage = "Distribution Platform is required!")]
        public int DistributionPlatformId { get; set; }
        // [ForeignKey("DistributionPlatformId")]
        // public DistributionPlatform DistributionPlatform { get; set; } //nazwa platformy na którą jest grą (Steam , GOG, Blizzard)

        //Platform
        [Display(Description = "Select Platform")]
        [Required(ErrorMessage = "Game Platform is required!")]
        public int PlatformId { get; set; }
        //  [ForeignKey("PlatformId")]
        //  public Platform Platform { get; set; } //nazwa platformy na jaką jest grą (PC, XBOX, PS5)

        //public Platform Platform { get; set; } 

        ////Producer
        [Display(Description = "Select a Publisher")]
        [Required(ErrorMessage = "Game publisher is required!")]
        public int PublisherId { get; set; }
     //   [ForeignKey("PublisherId")]
     //   public Publisher Publisher { get; set; } //producent gry


    
    }
}
