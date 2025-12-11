using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class WeatherApiService : MonoBehaviour
{
    public static WeatherApiService instance;

    private const string ApiKey = "f0ace7fac17343cb8b885513251112";

    private void Awake()
    {
        instance = this;
    }

    public IEnumerator GetWeather(string city, Action<string> callback)
    {
        string url =
            $"https://api.weatherapi.com/v1/current.json?key={ApiKey}&q={city}&aqi=no";

        using (UnityWebRequest request = UnityWebRequest.Get(url))
        {
            yield return request.SendWebRequest();

            if (request.result != UnityWebRequest.Result.Success)
            {
                callback?.Invoke("Error: " + request.error);
                yield break;
            }

            string json = request.downloadHandler.text;
            WeatherApiResponse data = JsonUtility.FromJson<WeatherApiResponse>(json);

            string formatted =
                $"{data.location.name}: {data.current.temp_c}°C, {data.current.condition.text}";

            callback?.Invoke(formatted);
        }
    }
}
