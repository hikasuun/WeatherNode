/*
 * SaveState.cs
 * Language: C# 
 * allows the serialization of user configuration on exit
 * 
 * April 2022
 */
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mail;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Runtime.Serialization;


namespace WeatherNode
{
    [Serializable]
    public class userSaveState //holds all data relevant to user configuration
    {
        private string userName; // holds user's name
        private String userEmail; // holds user's email address
        private string locationName;
        private ArrayList notificationArrayList = new ArrayList(); //to hold converted notification list, generic lists are not able to be used in soap (so notif list doesn't work)

        //utility fxns
        public string UserName { get => userName; set => userName = value; }
        public String UserEmail { get => userEmail; set => userEmail = value; }
        public ArrayList NotificationArrayList { get => notificationArrayList; set => notificationArrayList = value; }
        public string LocationName { get => locationName; set => locationName = value; }
    }

    public class UserSaveStateHelper
    {
        public userSaveState currentSaveState = new userSaveState();
        // Lists and Mailaddresses are unserializable when using SOAP, convert back into originally used form after deserialization
        public List<Notification> deserializedNotifications = new List<Notification>(); //will be used to deserialize and reassemble the serialized notificationlist
        public MailAddress deserializedEmail;//TODO: add email type to convert after deserializing
        public UserSaveStateHelper(BaseForm currentForm)
        {
            currentSaveState.UserName = currentForm.getUserName();
            currentSaveState.UserEmail = currentForm.getUserEmail().ToString();
            currentSaveState.NotificationArrayList.AddRange(currentForm.getNotificationList());
            currentSaveState.LocationName = currentForm.getLocationName();
        }

        public UserSaveStateHelper() { } //test to see if this creates a conflict

        public void writeUserState(String filePath)
        {
            IFormatter localFormatter = new SoapFormatter();
            Stream localStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
            localFormatter.Serialize(localStream, currentSaveState);
            localStream.Close();
        }


        public void readUserState(String filePath)
        {
            IFormatter localFormatter = new SoapFormatter();
            Stream localStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None);
            currentSaveState = (userSaveState)localFormatter.Deserialize(localStream);
            // conversion back to original types
            arrayToNotificationList();
            deserializedEmail = new MailAddress(currentSaveState.UserEmail);
            localStream.Close();
        }

        public void arrayToNotificationList()
        {
            foreach (Notification notification in currentSaveState.NotificationArrayList)
            {
                deserializedNotifications.Add(notification);
            }
        }
    }
}
