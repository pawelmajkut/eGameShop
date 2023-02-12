using eGameShop.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eGameShop.Models
{
    public class Game
    {   [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }    
        public double Price { get; set; }  
        public DateTime StartOfSale { get; set; } //początek daty sprzedaży gry
        public DateTime EndOfSale { get; set; } //koniec daty sprzedaży gry
        public int Quantity { get; set; } //ilość kopii  
        public GameCategory GameCategory { get; set; }
        //public string Producer { get; set; }

        //Relationships
        public List<Producer_Game> Producers_Games { get; set; }

        //DistributionPlatform
        public int DistributionPlatformId { get; set; }
        [ForeignKey("DistributionPlatformId")]
        public string DistributionPlatform { get; set; } //nazwa platformy na którą jest grą (Stem , GOG, Blizzard)

        //Platform
        public int PlatformId { get; set; }
        [ForeignKey("PlatformId")]
        public PlatformCategory Platform { get; set; } //nazwa platformy na jaką jest grą (PC, XBOX, PS5)

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public string Producer { get; set; } //producent gry



    }
}
