namespace FeverWebApp.Models
{
    public static class TemperatureChecker
    {
        public static string CheckTemperature(float temperature, string scale)
        {
            if (scale == "Fahrenheit")
            {
                temperature = (temperature - 32) * 5 / 9; // Convert to Celsius
            }

            if (temperature >= 38.0)
            {
                return "You have a fever.";
            }
            else if (temperature <= 35.0)
            {
                return "You might have hypothermia.";
            }
            else
            {
                return "Your temperature is normal.";
            }
        }
    }
}
