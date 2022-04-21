using System;
using System.Collections.Generic;
using transCA.Backend;

using Xamarin.Forms;

namespace transCA.Pages
{
    //Muhammad Choudhary
    //This is the page where the user can add funds
    public partial class AddFundsPage : ContentPage
    {
        public AddFundsPage()
        {
            InitializeComponent();
        }

        void ConfirmFunds_Clicked(System.Object sender, System.EventArgs e)
        {

            try
            {

                Account.CurrentUser.addFunds(Int32.Parse(InputFunds.Text));
            InputFunds.Text = "";

            Navigation.PushAsync(new CreateBookingPage());
            }
            catch (FormatException)
            {
                DisplayAlert("Invalid Entry", "Please enter only integers", "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Invalid Entry", "Please enter only integers", "OK");
            }




        }

    }
}
