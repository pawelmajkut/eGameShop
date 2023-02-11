using eGameShop.Data;
using System.ComponentModel.DataAnnotations;

namespace eGameShop.Models
{
    public class Game
    {   [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }    
        public int Price { get; set; }  
        public DateTime StartOfSale { get; set; } //początek daty sprzedaży gry
        public DateTime EndOfSale { get; set; } //koniec daty sprzedaży gry
        public int Quantity { get; set; } //ilość kopii
        //public string DistributionPlatform { get; set; }   //nazwa platformy z grą
        //public string Publisher { get; set; }   
        public GameCategory GameCategory { get; set; }
        //public string Producer { get; set; }



    }
}
