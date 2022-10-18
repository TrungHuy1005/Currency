using Amazon.CodePipeline.Model;
using Amazon.SimpleDB.Model;
using AutoMapper;
using Currency.Interface;
using Currency.Models;
using Currency.ResponseObj;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Currency.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        private readonly IGetListStockInforService getListStockInforService;
        private readonly IConfiguration configuration;
        private readonly IMapper mapper;
        public HomeController(IGetListStockInforService getListStockInforService, IConfiguration configuration, IMapper mapper)
        {
            this.getListStockInforService = getListStockInforService;
            this.configuration = configuration;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var url = configuration["APIYahooFinance"];
            var key = configuration["APIKey"];
            var endpoint = configuration["EndpointYahooFinanceStock"];
            var symbols = GetListSymbolsIntoYahooFinance(url, key).Result;
            var stockArr = new List<StockEntity>();
            foreach (var item in symbols)
            {
                var api = endpoint + item.symbol.ToString();
                var data = await getListStockInforService.SendRequest(key, url, api);
                var stock = mapper.Map<StockResponse>(data);
                foreach(var h in stock.quoteResponse.result)
                {
                    stockArr.Add(h);
                }
            }
            return View(stockArr);
        }

        public async Task<List<QuoteSymbol>> GetListSymbolsIntoYahooFinance(string url, string key)
        {
            var symbolAPI = configuration["EndpointYahooSymbol"];
            RegionEntity regions = new RegionEntity();
            List<QuoteSymbol> symbols = new List<QuoteSymbol>();
            foreach(var region in regions.ListRegionCode)
            {
                var api = symbolAPI + region.ToString();
                var data = await getListStockInforService.SendRequest(key, url, api);
                var symbol = mapper.Map<SymbolResponse>(data);
                if (symbol?.finance != null)
                {
                    foreach (var item in symbol.finance.result[0].quotes)
                    {
                        if (symbols.Count >= 10) return symbols;
                        symbols.Add(item);
                    }
                }
            }
            return symbols;
        }
        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction();
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction();
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction();
            }
            catch
            {
                return View();
            }
        }
    }
}
