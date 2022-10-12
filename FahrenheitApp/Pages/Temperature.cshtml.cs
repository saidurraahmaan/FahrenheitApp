using FahrenheitApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FahrenheitApp.Pages
{
    public class TemperatureModel : PageModel
    {
        public double temperatureCelcius;
        public double temperatureFahrenheit;

        public void OnGet()
        {
        }

        public void OnPost()
        {
            temperatureCelcius = Convert.ToDouble(Request.Form["TemperatureCelcius"]);
            temperatureFahrenheit = Temperature.CelciusToFahrenheit(temperatureCelcius);
        }
    }
}
