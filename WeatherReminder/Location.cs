/*
 * Location.cs
 * Language : C#
 * Class for holding location data in objects
 * January 2022 -
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherNode
{
    [Serializable] 
    internal class Location
    {
        private string LocationName; // hold location name
        private string LocationWeather; // hold location current weather
        private string LocationTemperature; // hold location temperature
        private string LocationHumidity; // hold location humidity
        private string LocationWindChill; // hold location wind chill
        private string LocationForecast; // hold location forecast
        private string LocationURL; // hold location's URL

        // Constructor
        public Location(string name,string weather, string temp, string humidity,
                        string windChill, string forecast, string url)
        {
            SetLocation(name);
            SetWeather(weather);
            SetTemp(temp);
            SetHumidity(humidity);
            SetWindChill(windChill);
            setForecast(forecast);
            SetURL(url);
        }


        // Getter and Setter utility functions
        public string GetLocation() { return LocationName; }
        public string GetWeather() { return LocationWeather; }
        public string GetTemp() { return LocationTemperature; }
        public string GetHumidity() { return LocationHumidity; }
        public string GetWindChill() { return LocationWindChill; }
        public string GetForecast() { return LocationForecast; }
        public string GetUrl() { return LocationURL; }
        public void SetLocation(string location) { LocationName = location; }
        public void SetWeather(string weather) { LocationWeather = weather; }
        public void SetTemp(string temp) { LocationTemperature = temp; }
        public void SetHumidity(string humidity) { LocationHumidity = humidity; }
        public void SetWindChill(string windChill) { LocationWindChill = windChill; }
        public void setForecast(string forecast) { LocationForecast = forecast; }
        public void SetURL(string url) { LocationURL = url; }
    }
}
