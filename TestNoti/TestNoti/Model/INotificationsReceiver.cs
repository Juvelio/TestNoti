using System;
using System.Collections.Generic;
using System.Text;

namespace TestNoti.Model
{
    public interface INotificationsReceiver
    {
        event EventHandler<string> ErrorReceived;

        event EventHandler<string> NotificationReceived;

        void RaiseErrorReceived(string message);

        void RaiseNotificationReceived(string message);
    }
}
