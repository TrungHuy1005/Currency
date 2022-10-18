using System.Collections.Generic;

namespace Currency.Models
{
    public class SymbolEntity
    {
        public List<SymbolData> result { get; set; }
    }
    public class SymbolData
    {
        public List<QuoteSymbol> quotes { get; set; }

    }
    public class QuoteSymbol
    {
        public string symbol { get; set; }
    } 
}
