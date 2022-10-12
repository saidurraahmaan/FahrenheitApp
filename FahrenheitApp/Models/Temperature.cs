namespace FahrenheitApp.Models
{
    public class Temperature
    {
        public static double CelciusToFahrenheit(double Tc)
        {
            double Tf;
            Tf = (9 * Tc / 5) + 32;
            return Tf;
        }
        public static double FahrenheitToCelcius(double Tf)
        {
            double Tc;
            Tc = (Tf - 32) * (5 / 9);
            return Tc;
        }
    }
}
