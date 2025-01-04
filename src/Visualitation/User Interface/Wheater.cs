public WeatherController weatherController;

public void OnWeatherChange(string weather)
{
    weatherController.SetWeather(weather);
}
