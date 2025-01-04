using UnityEngine;

public class WeatherController : MonoBehaviour
{
    public GameObject rainEffect;
    public GameObject snowEffect;
    public Light sunLight;

    public void SetWeather(string weather)
    {
        switch (weather)
        {
            case "Sunny":
                sunLight.intensity = 1f;
                rainEffect.SetActive(false);
                snowEffect.SetActive(false);
                break;

            case "Rainy":
                sunLight.intensity = 0.5f;
                rainEffect.SetActive(true);
                snowEffect.SetActive(false);
                break;

            case "Snowy":
                sunLight.intensity = 0.7f;
                rainEffect.SetActive(false);
                snowEffect.SetActive(true);
                break;
        }

        Debug.Log($"Cuaca berubah menjadi {weather}");
    }
}
