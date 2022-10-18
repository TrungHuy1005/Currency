using AutoMapper;
using Currency.Models;
using Currency.ResponseObj;
using Newtonsoft.Json.Linq;

namespace Currency.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MarketSummaryResponse, JObject>();
            CreateMap<StockResponse, JObject>();
            CreateMap<SymbolResponse, JObject>();
        }
    }
}
