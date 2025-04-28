namespace PortfolioCore7.Entities
{
    public class Portfolio
    {
        public int PortfolioId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string imageUrl { get; set; }
        public string ProjectUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
