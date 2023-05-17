namespace BFPriceScraper.Models
{
    public class Product
	{
		public string ProductId { get; set; }
		public string BFUrl { get; set; }
		public string Competitor1Url { get; set; }
		public string Competitor1Variation { get; set; }
		public string Comptetitor2Url { get; set; }
        public string Competitor2Variation { get; set; }
		public string Competitor1ExtractedPrice { get; set; }
        public string Competitor2ExtractedPrice { get; set; }
		public string BFExtractedPrice { get; set; }
    }
}

