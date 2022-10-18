namespace Currency.Models
{
    public class MarketSummary //Tổng quan thị trường
    {
        public string exchange { get; set; }
        public long exchangeDataDelayedBy { get; set; }
        public string exchangeTimezoneName { get; set; }
        public string exchangeTimezoneShortName { get; set; }
        public long firstTradeDateMilliseconds { get; set; }
        public string fullExchangeName { get; set; }
        public long gmtOffSetMilliseconds { get; set; }
        public string language { get; set; }
        public string market { get; set; }
        public string marketState { get; set; }
        public long priceHint { get; set; }
        public string quoteSourceName { get; set; }
        public string quoteType { get; set; }
        public string region { get; set; }
        public string shortName { get; set; }
        public long sourceInterval { get; set; }
        public string symbol { get; set; }
        public bool tradeable { get; set; }
        public bool triggerable { get; set; }
        public MarketChange regularMarketChange { get; set; }
        public MarketChange regularMarketChangePercent { get; set; }
        public MarketChange regularMarketPreviousClose { get; set; }
        public MarketChange regularMarketPrice { get; set; }
        public MarketChange regularMarketTime { get; set; }
    }
}
