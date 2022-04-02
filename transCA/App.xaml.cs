using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using transCA.Pages;

namespace transCA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new InsufficientFundsPage());
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
