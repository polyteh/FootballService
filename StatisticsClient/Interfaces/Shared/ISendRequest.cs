using RestSharp;
using System.Threading.Tasks;

namespace StatisticsClient.Interfaces.Shared
{
    public interface ISendRequest
    {
        Task<IRestResponse<T>> SendLoggedRequest<T>(RestClient client, RestRequest request);
    }
}
