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
    internal class Notification
    {
        private string notificationName; // store the name of the notification
        private DateTime notificationDate; // store time the notification should be sent
        // WARNING: MAY NOT USE notificationOptions, depends on intent of notification tab
        private bool[] notificationOptions; // store notifications as array of boolean val.
        /*
         * ARRAY SPACE      NOTIFICATION
         *           0      
         */

        // Constructor
        public Notification(string notiName, DateTime notiTime, bool[] notiOption)
        {
            setNotificationName(notiName);
            setNotificationDate(notiTime);
            setNotificationOptions(notiOption);
        }
        
        // Getter and Setter utility functions
        public string getNotificationName()
        {
            return notificationName;
        }
        public DateTime getNotificationDate()
        {
            return notificationDate;
        }
        public bool[] getNotificationOptions()
        {
            if (notificationOptions == null)
            {
                return null;
            }
            else
            {
                return notificationOptions;
            }
        }
        public void setNotificationName(string notiName)
        {
            this.notificationName = notiName;
        }
        public void setNotificationDate(DateTime notiTime)
        {
            this.notificationDate = notiTime;
        }
        public void setNotificationOptions (bool[] notiOptions)
        {
            if (notiOptions == null)
            {
                notificationOptions = null;
            }
            else
            {
                this.notificationOptions = notiOptions;
            }
        }
    }
}
