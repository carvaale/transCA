using System;
using System.Collections.Generic;
using transCA.Backend;

using Xamarin.Forms;

namespace transCA.Pages
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        void LoginButton_Clicked(System.Object sender, System.EventArgs e)
        {
            //Check if the password entered is the same as confirmed password
            if (PasswordEntry.Text != ConfirmPasswordEntry.Text) {

                DisplayAlert("Paswword Error", "Entered Password Does Not Match","OK");

            } else
            {
                Account.CurrentUser = new Account(UserNameEntry.Text, EmailEntry.Text, PasswordEntry.Text);

                Navigation.PushAsync(new MainPage());
            }


        }







    }
}
