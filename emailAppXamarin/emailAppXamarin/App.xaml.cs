using emailAppXamarin.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace emailAppXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EmailsPage()) { BarBackgroundColor = Color.FromHex("D8401F"), BarTextColor = Color.White };
          

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
