/*
 * Notification.cs
 * Language : C#
 * Class for holding user notification options
 * in an object
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
    public class Notification
    {
        private DateTime notificationDate; // store time the notification should be sent
        private int notificationHeat; // store notification hot temp
        private int notificationCold; // store notification cold temp
        private bool[] notificationOptions = new bool[4]; // store notifications as array of boolean val.
        /*
         * ARRAY SPACE      NOTIFICATION
         *           0      RAIN
         *           1      WIND
         *           2      FOG
         *           3      HUMIDITY
         */

        // Constructor
        public Notification( DateTime notiTime, int notiHeat, int notiCold, bool[] notiOption)
        {
            setNotificationDate(notiTime);
            setNotificationHeat(notiHeat);
            setNotificationCold(notiCold);
            setNotificationOptions(notiOption);
        }
        
        // Getter and Setter utility functions
        public int getNotificationHeat()
        {
            return notificationHeat;
        }
        public int getNotificationCold()
        {
            return notificationCold;
        }
        public DateTime getNotificationDate()
        {
            return notificationDate;
        }
        public bool[] getNotificationOptions()
        {
            return notificationOptions;
        }
        public void setNotificationHeat(int notiHeat)
        {
            this.notificationHeat = notiHeat;
        }
        public void setNotificationCold(int notiCold)
        {
            this.notificationCold = notiCold;
        }
        public void setNotificationDate(DateTime notiTime)
        {
            this.notificationDate = notiTime;
        }
        public void setNotificationOptions (bool[] notiOptions)
        {
            this.notificationOptions = notiOptions;
        }
    }
}
