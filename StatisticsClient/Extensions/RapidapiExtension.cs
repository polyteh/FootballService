using RestSharp;
using StatisticsClient.Configuration;

namespace StatisticsClient.Extensions
{
    public static class RapidapiExtension
    {
        public static void AddRapidapiHeaders(this RestRequest request, RapidapiConfiguration configuration)
        {
            if (configuration.Headres == null)
            {
                return;
            }

            foreach (var header in configuration.Headres)
            {
                request.AddHeader(header.Key, header.Value);
            }
        }
    }
}
