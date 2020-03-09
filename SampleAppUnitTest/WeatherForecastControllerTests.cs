using System.Linq;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using SampleApp.Controllers;

namespace SampleAppUnitTest
{
    public class WeatherForecastControllerTests
    {
        private WeatherForecastController _controller;
       [SetUp]
        public void Setup()
        {
           _controller = new WeatherForecastController();
        }

        [Test]
        public void Test1()
        {
            var result = _controller.Get();
            Assert.AreEqual(result.Count(),5);
        }
    }
}