using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using transCA.Backend;
using transCA.Pages;

namespace transCA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ExistingBookingButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ExistingBooking());
        }

        private void CreateBookingButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateBookingPage());
        }

        private void AddFundsButton_Clicked(object sender, EventArgs e)
        {
           Navigation.PushAsync(new AddFundsPage());
        }

        private void LogOutButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignInPage());
        }
    }
}
