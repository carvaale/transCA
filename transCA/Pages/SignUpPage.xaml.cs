using System;
using System.Collections.Generic;
using transCA.Backend;

using Xamarin.Forms;

namespace transCA.Pages
{
    //Muhammad Choudhary
    //This page lets the user sign up
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

            }
            if (AccountRepository.AccountExists(EmailEntry.Text)) {
                DisplayAlert("Error", "Email is already used", "OK");
                return;

            }
            else
            {
                Account.CurrentUser = new Account(UserNameEntry.Text, PasswordEntry.Text);

                var account = new Account(UserNameEntry.Text, EmailEntry.Text, PasswordEntry.Text);

                AccountRepository.AddAccount(account);

                Navigation.PushAsync(new SignInPage());
            }


        }







    }
}
