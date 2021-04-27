using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNoti.Model;
using Xamarin.Forms;

namespace TestNoti
{
    public partial class MainPage : ContentPage
    {
        private readonly INotificationsReceiver _notificationsReceiver;

        public MainPage()
        {
            _notificationsReceiver = DependencyService.Get<INotificationsReceiver>();
            _notificationsReceiver.NotificationReceived += NotificationsReceiver_NotificationReceived;
            _notificationsReceiver.ErrorReceived += NotificationsReceiver_ErrorReceived;

            InitializeComponent();
        }

        private void NotificationsReceiver_ErrorReceived(object sender, string e)
        {
            Dispatcher.BeginInvokeOnMainThread(() =>
            {
                MainLabel.TextColor = Color.Red;
                MainLabel.Text = e;
            });
        }

        private void NotificationsReceiver_NotificationReceived(object sender, string e)
        {
            Dispatcher.BeginInvokeOnMainThread(() =>
            {
                MainLabel.TextColor = Color.Black;
                MainLabel.Text = e;
            });
        }
    }
}
