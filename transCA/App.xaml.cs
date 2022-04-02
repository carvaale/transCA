using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace transCA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CreateBookingPage());

            //MainPage = new NavigationPage(new Pages.AddFundsPage());

           
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
