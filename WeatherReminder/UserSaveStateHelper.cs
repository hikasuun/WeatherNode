/*
 * SaveState.cs
 * Language: C# 
 * 
 * 
 * April 2022 - 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Net.Mail;


namespace WeatherNode //need to save notification vector, current location, and username and email
{
    [Serializable]
    public class userSaveState
    {
        private string userName; // holds user's name
        private String userEmail; // holds user's email address
        private List<Notification> notificationList = new List<Notification>(); // NEED TO MAKE SERIALIZABLE NOTIFICATION LIST
        private string locationName, locationURL;

        public string UserName { get => userName; set => userName = value; }
        public String UserEmail { get => userEmail; set => userEmail = value; }
        public List<Notification> NotificationList { get => notificationList; set => notificationList = value; }
        public string LocationName { get => locationName; set => locationName = value; }
        public string LocationURL { get => locationURL; set => locationURL = value; }
    }

    public class UserSaveStateHelper
    {
        userSaveState currentSaveState = new userSaveState();

        public UserSaveStateHelper(BaseForm currentForm)
        {
            currentSaveState.UserName =  currentForm.getUserName();
            currentSaveState.UserEmail = currentForm.getUserEmail().ToString();
            {
                String[] tempLocationArray = currentForm.getBasicLocationData();
                currentSaveState.LocationName = tempLocationArray[0];
                currentSaveState.LocationURL = tempLocationArray[1];
            }
            currentSaveState.NotificationList.AddRange(currentForm.getNotificationList());
        }

        public void writeUserState(String filename)
        {
            XmlSerializer baseSerializer = new XmlSerializer(typeof(userSaveState));
            TextWriter writer = new StreamWriter(filename);
            baseSerializer.Serialize(writer, currentSaveState);
        }


        public void readUserState(String filename)
        {

        }
    }
}
