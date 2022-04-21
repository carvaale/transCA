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
        // Klajdi Hoxhalli
        //This is the main page which is like a main menu
        //It allows the user to navigate to the different pages of the app for the different functionalities

        public MainPage()
        {
            InitializeComponent();
            transCA_logo.Source = ImageSource.FromResource($"transCA.Images.transCA_logo.png", typeof(MainPage));

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
