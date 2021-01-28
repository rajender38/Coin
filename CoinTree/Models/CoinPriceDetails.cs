using System;


namespace CoinTree.Models
{
    public class CoinPriceDetails
    {
        public string Sell { get; set; }
        public string Buy { get; set; }
        public decimal Ask { get; set; }
        public decimal Bid { get; set; }
        public decimal Rate { get; set; }
        public decimal SpotRate { get; set; }
        public string Market { get; set; }
        public DateTime Timestamp { get; set; }
        public string RateType { get; set; }
        public object RateSteps { get; set; }

    }
}