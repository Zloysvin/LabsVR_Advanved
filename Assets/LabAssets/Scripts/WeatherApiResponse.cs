using UnityEngine;

[System.Serializable]
public class WeatherApiResponse
{
    public LocationInfo location;
    public CurrentInfo current;

    [System.Serializable]
    public class LocationInfo
    {
        public string name;
    }

    [System.Serializable]
    public class CurrentInfo
    {
        public float temp_c;
        public ConditionInfo condition;
    }

    [System.Serializable]
    public class ConditionInfo
    {
        public string text;
    }
}
