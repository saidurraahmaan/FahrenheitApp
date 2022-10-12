using FahrenheitApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestTemperature
{
    [TestClass]
    public class UnitTestTempConversion
    {
        [TestMethod]
        public void TestFahrenheitTemperatureConversion()
        {
            double temperatureCelcius = -40;
            double temperatureFahrenheitActual;
            double temperatureFahrenheitExpected = -40;


            temperatureFahrenheitActual = Temperature.CelciusToFahrenheit(temperatureCelcius);

            Assert.AreEqual(temperatureFahrenheitActual, temperatureFahrenheitExpected, 0.001, "Temperature conversion is wrong for 1");
        }

        [TestMethod]
        public void TestFahrenheitTemperatureConversion2()
        {
            double temperatureCelcius = 100;
            double temperatureFahrenheitActual;
            double temperatureFahrenheitExpected = 212;


            temperatureFahrenheitActual = Temperature.CelciusToFahrenheit(temperatureCelcius);

            Assert.AreEqual(temperatureFahrenheitActual, temperatureFahrenheitExpected, 0.001, "Temperature conversion is wrong for 2");
        }
    }
}
