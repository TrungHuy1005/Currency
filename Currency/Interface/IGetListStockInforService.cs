using System.Threading.Tasks;

namespace Currency.Interface
{
    public interface IGetListStockInforService
    {
        Task<object> SendRequest(string key, string url, string endpoint);
    }
}
