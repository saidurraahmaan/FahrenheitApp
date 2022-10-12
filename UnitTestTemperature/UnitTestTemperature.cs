using FahrenheitApp.Models;

namespace UnitTestTemperature
{
    [TestClass]
    public class UnitTestTemperature
    {
        [TestMethod]
        public void TestFahrenheitTemperatureConversion()
        {
            double temperatureCelcius = 2;
            double temperatureFahrenheitActual;
            double temperatureFahrenheitExpected = 71.6;


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