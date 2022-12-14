namespace Currency.Models
{
    public class StockEntity
    {
        public decimal ask { get; set; }
        public int askSize { get; set; }
        public long averageDailyVolume10Day { get; set; }
        public long averageDailyVolume3Month { get; set; }
        public decimal bid { get; set; }
        public int bidSize { get; set; }
        public decimal bookValue { get; set; }
        public string currency { get; set; }
        public string displayName { get; set; }
        public long dividendDate { get; set; }
        public long earningsTimestamp { get; set; }
        public long earningsTimestampEnd { get; set; }
        public long earningsTimestampStart { get; set; }
        public decimal epsCurrentYear { get; set; }
        public decimal epsForward { get; set; }
        public decimal epsTrailingTwelveMonths { get; set; }
        public bool esgPopulated { get; set; }
        public string exchange { get; set; }
        public int exchangeDataDelayedBy { get; set; }
        public string exchangeTimezoneName { get; set; }
        public string exchangeTimezoneShortName { get; set; }
        public decimal fiftyDayAverage { get; set; }
        public decimal fiftyDayAverageChange { get; set; }
        public decimal fiftyDayAverageChangePercent { get; set; }
        public decimal fiftyTwoWeekHigh { get; set; }
        public decimal fiftyTwoWeekHighChange { get; set; }
        public decimal fiftyTwoWeekHighChangePercent { get; set; }
        public decimal fiftyTwoWeekLow { get; set; }
        public decimal fiftyTwoWeekLowChange { get; set; }
        public decimal fiftyTwoWeekLowChangePercent { get; set; }
        public string fiftyTwoWeekRange { get; set; }
        public string financialCurrency { get; set; }
        public long firstTradeDateMilliseconds { get; set; }
        public decimal forwardPE { get; set; }
        public string fullExchangeName { get; set; }
        public long gmtOffSetMilliseconds { get; set; }
        public string language { get; set; }
        public string longName { get; set; }
        public string market { get; set; }
        public long marketCap { get; set; }
        public string marketState { get; set; }
        public string messageBoardId { get; set; }
        public decimal postMarketChange { get; set; }
        public decimal postMarketChangePercent { get; set; }
        public decimal postMarketPrice { get; set; }
        public long postMarketTime { get; set; }
        public decimal priceEpsCurrentYear { get; set; }
        public int priceHint { get; set; }
        public long priceToBook { get; set; }
        public string quoteSourceName { get; set; }
        public string quoteType { get; set; }
        public string typeDisp { get; set; }
        public string region { get; set; }
        public decimal regularMarketChange { get; set; }
        public decimal regularMarketChangePercent { get; set; }
        public decimal MyProregularMarketDayHighperty { get; set; }
        public decimal regularMarketDayLow { get; set; }
        public string regularMarketDayRange { get; set; }
        public decimal regularMarketOpen { get; set; }
        public decimal regularMarketPreviousClose { get; set; }
        public decimal regularMarketPrice { get; set; }
        public long regularMarketTime { get; set; }
        public long regularMarketVolume { get; set; }
        public long sharesOutstanding { get; set; }
        public string shortName { get; set; }
        public int sourceInterval { get; set; }
        public string symbol { get; set; }
        public bool tradeable { get; set; }
        public decimal trailingAnnualDividendRate { get; set; }
        public decimal trailingAnnualDividendYield { get; set; }
        public decimal trailingPE { get; set; }
        public bool triggerable { get; set; }
        public decimal twoHundredDayAverage { get; set; }
        public decimal twoHundredDayAverageChange { get; set; }
        public decimal twoHundredDayAverageChangePercent { get; set; }
    }
}
