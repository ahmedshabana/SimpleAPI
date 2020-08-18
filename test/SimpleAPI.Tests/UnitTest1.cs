using System;
using Xunit;
using SimpleAPI.Controllers;


namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        
        SimpleAPI.Controllers.WeatherForecastController Weather1 =new WeatherForecastController();
        [Fact]
        public void Test1()
        {

        }
         [Fact]
        public void GetWeatherData()
        {
            
            var returnValue = Weather1.Get();

             Assert.Equal("Ahmed Shabana" ,returnValue.ToString());



        }
    }
}
