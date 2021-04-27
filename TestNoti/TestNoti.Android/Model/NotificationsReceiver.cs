using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestNoti.Droid.Model;
using TestNoti.Model;

[assembly: Xamarin.Forms.Dependency(typeof(NotificationsReceiver))]

namespace TestNoti.Droid.Model
{
    public class NotificationsReceiver : INotificationsReceiver
    {
        //public event EventHandler<string> ErrorReceived;

        //public event EventHandler<string> NotificationReceived;

        //public void RaiseErrorReceived(string message)
        //{
        //    ErrorReceived?.Invoke(this, message);
        //}

        //public void RaiseNotificationReceived(string message)
        //{
        //    NotificationReceived?.Invoke(this, message);
        //}
        public event EventHandler<string> ErrorReceived;
        public event EventHandler<string> NotificationReceived;

        public void RaiseErrorReceived(string message)
        {
            ErrorReceived?.Invoke(this, message);
        }

        public void RaiseNotificationReceived(string message)
        {
            NotificationReceived?.Invoke(this, message);
        }
    }
}