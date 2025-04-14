using System.Text.Json.Serialization;

public class WeatherResponse
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("main")]
    public MainWeather? Main { get; set; }

    [JsonPropertyName("weather")]
    public WeatherDescription[]? Weather { get; set; }
}

public class MainWeather
{
    [JsonPropertyName("temp")]
    public float Temp { get; set; }
}

public class WeatherDescription
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }
}
