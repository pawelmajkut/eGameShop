using System.ComponentModel.DataAnnotations;

namespace eGameShop.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
    }
}
