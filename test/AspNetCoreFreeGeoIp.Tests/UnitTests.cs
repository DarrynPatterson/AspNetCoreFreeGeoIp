using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AspNetCoreFreeGeoIp.Tests
{
    public class UnitTests
    {
        #region Constructors

        public UnitTests()
        {
        }

        #endregion

        [Fact]
        public void GetCodes_Test()
        {
            var remoteIp = "74.125.224.72";

            var result = GeoIpWrapper.GetGeoIp(remoteIp);

            Assert.Equal(result.Ip, remoteIp);
            Assert.Equal(result.CountryCode, "US");
        }
    }
}