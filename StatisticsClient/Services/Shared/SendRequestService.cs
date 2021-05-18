using RestSharp;
using StatisticsClient.Interfaces.Shared;
using System;
using System.Threading.Tasks;

namespace StatisticsClient.Services.Shared
{
    public class SendRequestService : ISendRequest
    {
        public async Task<IRestResponse<T>> SendLoggedRequest<T>(RestClient client, RestRequest request)
        {
            if (client == null)
            {
                //TODO: add logging and exception customization
                throw new NullReferenceException();
            }

            var response = await client.ExecuteTaskAsync<T>(request);

            if (!response.IsSuccessful)
            {
                //TODO: add logging and exception customization
                throw new Exception();
            }

            return response;
        }
    }
}
