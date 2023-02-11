using System.ComponentModel.DataAnnotations;

namespace eGameShop.Models
{
    public class Platform
    {
        [Key]
        public int Id { get; set; }

        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationships
        public List<Game> Games { get; set; }
    }
}
