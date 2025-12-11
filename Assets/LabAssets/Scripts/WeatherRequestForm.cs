using TMPro;
using UnityEngine;

public class WeatherRequestForm : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField city;
    [SerializeField]
    private TMP_Text weather;

    public void RequestWeather()
    {
        StartCoroutine(WeatherApiService.instance.GetWeather(city.text, result =>
        {
            weather.text = result;
        }));
    }
}
