public static class ConversorTemperatura 
{
    public static double CelsiusParaFahrenheit(double celsius)
    {
        return (celsius*9/5) + 32;
    }
    public static double fahrenheitParaCelsius (double fahrenheit)
    {
        return (fahrenheit -32) *5/9;
    }
    
}