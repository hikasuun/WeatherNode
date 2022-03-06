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
        private string LocationTemperature;
        private string LocationHumidity;
        private string LocationWindChill;
        private string LocationURL;

        // Constructor
        // Takes in: Location Name, Temperature, Humidity, Wind Chill,
        //           and Locations URL
        public Location(string name, string temp, string humidity,
                        string windChill, string url)
        {
            SetLocation(name);
            SetTemp(temp);
            SetHumidity(humidity);
            SetWindChill(windChill);
            SetURL(url);
        }


        // Getter and Setter utility functions
        public string GetLocation() { return LocationName; }
        public string GetTemp() { return LocationTemperature; }
        public string GetHumidity() { return LocationHumidity; }
        public string GetWindChill() { return LocationWindChill; }
        public string GetUrl() { return LocationURL; }
        public void SetLocation(string location) { LocationName = location; }
        public void SetTemp(string temp) { LocationTemperature = temp; }
        public void SetHumidity(string humidity) { LocationHumidity = humidity; }
        public void SetWindChill(string windChill) { LocationWindChill = windChill; }
        public void SetURL(string url) { LocationURL = url; }
    }
}
