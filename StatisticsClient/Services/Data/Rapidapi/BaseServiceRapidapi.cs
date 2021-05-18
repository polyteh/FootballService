using Microsoft.Extensions.Options;
using RestSharp;
using StatisticsClient.Configuration;
using StatisticsClient.Interfaces.Shared;

namespace StatisticsClient.Services.Data.Rapidapi
{
    public abstract class BaseServiceRapidapi
    {
        protected readonly RestClient _client;
        protected readonly RapidapiConfiguration _rapidapiConfiguration;
        protected readonly ISendRequest _sendRequest;
        public BaseServiceRapidapi(IOptionsSnapshot<RapidapiConfiguration> rapidapiConfiguration,
            ISendRequest sendRequest)
        {
            _rapidapiConfiguration = rapidapiConfiguration.Value;
            _sendRequest = sendRequest;

            if (_rapidapiConfiguration != null)
            {
                _client = new RestClient(_rapidapiConfiguration.BaseUrl);
            }
        }
    }
}
