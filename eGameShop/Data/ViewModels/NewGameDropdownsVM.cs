using eGameShop.Models;

namespace eGameShop.Data.ViewModels
{
    public class NewGameDropdownsVM
    {
        public NewGameDropdownsVM()
        {
            Publishers = new List<Publisher>();
            Platforms = new List<Platform>();
            Producers = new List<Producer>();
            DistributionPlatforms = new List<DistributionPlatform>();


        }
        public List<Publisher> Publishers { get; set; }
        public List<Platform> Platforms { get; set; }
        public List<Producer> Producers { get; set; }
        public List<DistributionPlatform> DistributionPlatforms { get; set; }
    }
}
