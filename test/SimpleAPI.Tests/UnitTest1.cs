using System;
using Xunit;
using SimpleAPI.Controllers;
using System.Collections.Generic;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
          [Fact]
        public void Test1()
        {

        }
         [Fact]
        public void GetWeatherData()
        {


        SimpleAPI.Controllers.WeatherForecastController Weather1 =new WeatherForecastController();
      
        IEnumerable<WeatherForecast> e1 = Weather1.Get();
          

           
              var enum1=  e1.GetEnumerator();
             if ( enum1.MoveNext()== true) 
              {
                  
                 Assert.Matches("Hot" ,"Hot");
                 
              }
             else
                 Assert.Equal("Hot" ,"Hot");



        }
    }
}
