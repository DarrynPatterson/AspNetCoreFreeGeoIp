using Xunit;

namespace AspNetCoreFreeGeoIp.Tests
{
    public class UnitTests
    {
        [Fact]
        public void ValidRemoteIp_Test()
        {
            var remoteIp = "74.125.224.72";

            var result = GeoIpWrapper.GetGeoIp(remoteIp);

            Assert.Equal(result.Ip, remoteIp);
            Assert.Equal(result.CountryCode, "US");
            Assert.Equal(result.CountryName, "United States");
            Assert.Equal(result.RegionCode, "CA");
            Assert.Equal(result.RegionName, "California");
            Assert.Equal(result.City, "Mountain View");
            Assert.Equal(result.ZipCode, "94043");
            Assert.Equal(result.TimeZone, "America/Los_Angeles");
            Assert.Equal(result.Latitude, "37.4192");
            Assert.Equal(result.Longitude, "-122.0574");
            Assert.Equal(result.MetroCode, "807");
        }

        [Fact]
        public void InvalidRemoteIp_Test()
        {
            var remoteIp = "x.x.x.x";

            var result = GeoIpWrapper.GetGeoIp(remoteIp);

            Assert.Equal(result, null);
        }
    }
}