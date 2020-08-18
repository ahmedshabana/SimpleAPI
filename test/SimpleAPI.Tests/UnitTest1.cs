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
            System.Collections.Generic.IEnumerable<WeatherForecast> e = Weather1.Get();
           
             Assert.Equal("Hot" ,e.GetEnumerator().Current.Summary.ToString());



        }
    }
}
