using Amazon.ECS.Model;
using Currency.Interface;
using Currency.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace Currency.Services
{
    public class GetListStockInforService : IGetListStockInforService
    {
        public async Task<object> SendRequest(string key, string url,string endpoint)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(url);
            httpClient.DefaultRequestHeaders.Add("X-API-KEY",
                key);
            httpClient.DefaultRequestHeaders.Add("accept",
                "application/json");

            var response = await httpClient.GetAsync(endpoint);
            var responseBody = await response.Content.ReadAsStringAsync();
            var data = (JObject)JsonConvert.DeserializeObject(responseBody);
            return data;
        }
    }
}
