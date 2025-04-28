using System.ComponentModel.DataAnnotations;

namespace PortfolioCore7.Entities
{
    public class Service
    {
        [Key]
        public int ServideId { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceIcon { get; set; }
        public string ServiceDescription { get; set; }
    }
}
