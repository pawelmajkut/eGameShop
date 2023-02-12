using System.ComponentModel.DataAnnotations;

namespace eGameShop.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

		[Display(Name = "ProfilePictureURL")]
		public string ProfilePictureURL { get; set; }
		[Display(Name = "FullName")]
		public string FullName { get; set; }
		[Display(Name = "Description")]
		public string Description { get; set; }  

        //Relationships
        public List<Producer_Game> Producers_Games { get; set; } 
    }
}
