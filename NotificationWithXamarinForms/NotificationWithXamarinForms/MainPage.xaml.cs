using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NotificationWithXamarinForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button_send_Clicked(object sender, EventArgs e)
        {
            var title = entry_title.Text;
            var text = entry_text.Text;
            CrossLocalNotifications.Current.Show(title, text);
        }
    }
}
