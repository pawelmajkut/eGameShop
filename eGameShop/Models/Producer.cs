using System.ComponentModel.DataAnnotations;
using eGameShop.Data;
using eGameShop.Data.Base;

namespace eGameShop.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }

		[Display(Name = "ProfilePictureURL")]
		[Required(ErrorMessage = "Profile Picture is required")]
		public string ProfilePictureURL { get; set; }

		[Display(Name = "FullName")]
		[Required(ErrorMessage = "Full Name is required")]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
		public string FullName { get; set; }

		[Display(Name = "Description")]
		[Required(ErrorMessage = "Description is required")]
		public string Description { get; set; }  

        //Relationships
        public List<Producer_Game> Producers_Games { get; set; } 
    }
}
