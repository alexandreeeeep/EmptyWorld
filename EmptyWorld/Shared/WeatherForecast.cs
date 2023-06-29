namespace EmptyWorld.Shared
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureK { get; set; }

        public string? Summary { get; set; }

        public string? Weather { get; set; } //=> 32 + (int)(TemperatureC / 0.5556);
    }
}