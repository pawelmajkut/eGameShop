namespace eGameShop.Models
{
    public class Producer_Game
    {

        public int GameId { get; set; }
        public Game Game { get; set; }  
        public int ProducerId { get; set; } 
        public Producer Producer { get; set; }  

    }
}
