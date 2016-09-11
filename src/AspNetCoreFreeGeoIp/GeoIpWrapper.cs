using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace AspNetCoreFreeGeoIp
{
    public class GeoIpWrapper
    {
        private const string BaseUrl = "https://freegeoip.net";

        public static GeoIpModel GetGeoIp(string remoteIp)
        {
            var format = "json";
            var requestUrl = $"{format}/{remoteIp}";
            var request = new RestRequest(requestUrl, Method.GET);
            var client = new RestClient(BaseUrl);
            var response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.Forbidden)
            {
                throw new WebException($"Request forbidden: {request.Resource}");
            }

            var json = response.Content;
            var content = JObject.Parse(json);
            var model = JsonConvert.DeserializeObject<GeoIpModel>(content.ToString());

            return model;
        }
    }
}