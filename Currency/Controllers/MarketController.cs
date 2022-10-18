using AutoMapper;
using Currency.Interface;
using Currency.ResponseObj;
using Currency.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace Currency.Controllers
{
    public class MarketController : Controller
    {
        private readonly IGetListStockInforService getListCurrrencyService;
        private readonly IConfiguration configuration;
        private readonly IMapper mapper;
        public MarketController(IGetListStockInforService getListCurrrencyService, IConfiguration configuration, IMapper mapper)
        {
            this.getListCurrrencyService = getListCurrrencyService;
            this.configuration = configuration;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var url = configuration["APIYahooFinance"];
            var key = configuration["APIKey"];
            var endpoint = configuration["EndpointYahooFinance"];
            var data = await getListCurrrencyService.SendRequest(key, url, endpoint);
            var marketSummary = mapper.Map<MarketSummaryResponse>(data);
            return View(marketSummary);
        }
    }
}
