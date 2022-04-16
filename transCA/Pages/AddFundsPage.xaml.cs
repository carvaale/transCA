using System;
using System.Collections.Generic;
using transCA.Backend;

using Xamarin.Forms;

namespace transCA.Pages
{
    public partial class AddFundsPage : ContentPage
    {
        public AddFundsPage()
        {
            InitializeComponent();
        }

        void ConfirmFunds_Clicked(System.Object sender, System.EventArgs e)
        {

            //try
            //{

            Account.CurrentUser.addFunds(Int32.Parse(InputFunds.Text));
            InputFunds.Text = "";

            Navigation.PushAsync(new CreateBookingPage());
            //}
            //catch (FormatException)
            //{
            //    DisplayAlert("Invalid Entry", "Please enter only integers", "OK");
            //}




        }

    }
}
