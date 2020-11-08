using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController weather = new WeatherForecastController();
        [Fact]
        public void GetReturnsMyMan() {
            var returnValue = weather.Get(1);
            Assert.Equal(1, returnValue);
        }

        [Fact]
        public void haha() {
            Assert.Equal(1, 1);
        }

        [Fact]
        public void hihi() {
            Assert.Equal(4, 4);
        }







        [Fact]
        public void Test1()
        {

        }
    }
}
