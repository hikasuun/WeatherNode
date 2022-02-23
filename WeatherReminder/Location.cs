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
        private string LocationName;
        private int LocationTemperature;
        private int LocationHumidity;
        private int LocationWindChill;
        private string LocationURL;

        // Constructor
        // Takes in: Location Name, Temperature, Humidity, Wind Chill,
        //           and Locations URL
        public Location(string name, int temp, int humidity,
                        int windChill, string url)
        {
            SetLocation(name);
            SetTemp(temp);
            SetHumidity(humidity);
            SetWindChill(windChill);
            SetURL(url);
        }


        // Getter and Setter utility functions
        public string GetLocation() { return LocationName; }
        public int GetTemp() { return LocationTemperature; }
        public int GetHumidity() { return LocationHumidity; }
        public int GetWindChill() { return LocationWindChill; }
        public string GetUrl() { return LocationURL; }
        public void SetLocation(string location) { LocationName = location; }
        public void SetTemp(int temp) { LocationTemperature = temp; }
        public void SetHumidity(int humidity) { LocationHumidity = humidity; }
        public void SetWindChill(int windChill) { LocationWindChill = windChill; }
        public void SetURL(string url) { LocationURL = url; }
    }
}
