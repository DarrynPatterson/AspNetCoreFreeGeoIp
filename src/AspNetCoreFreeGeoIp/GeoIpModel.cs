using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AspNetCoreFreeGeoIp
{
    public class GeoIpModel
    {
        [JsonProperty("ip", Order = 1)]
        public string Ip { get; set; }

        [JsonProperty("country_code", Order = 2)]
        public string CountryCode { get; set; }

        [JsonProperty("country_name", Order = 3)]
        public string CountryName { get; set; }

        [JsonProperty("region_code", Order = 4)]
        public string RegionCode { get; set; }

        [JsonProperty("region_name", Order = 5)]
        public string RegionName { get; set; }

        [JsonProperty("city", Order = 6)]
        public string City { get; set; }

        [JsonProperty("zip_code", Order = 7)]
        public string ZipCode { get; set; }

        [JsonProperty("time_zone", Order = 8)]
        public string TimeZone { get; set; }

        [JsonProperty("latitude", Order = 9)]
        public string Latitude { get; set; }

        [JsonProperty("longitude", Order = 10)]
        public string Longitude { get; set; }

        [JsonProperty("metro_code", Order = 11)]
        public string MetroCode { get; set; }
    }
}