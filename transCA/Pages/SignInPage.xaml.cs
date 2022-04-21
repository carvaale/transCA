using System;
using System.Collections.Generic;
using transCA.Backend;

using Xamarin.Forms;

namespace transCA.Pages
{
    //Muhammad Choudhary
    //This page lets the user sign in
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
            transCA_logo.Source = ImageSource.FromResource($"transCA.Images.transCA_logo.png", typeof(SignInPage));

        }

        void LoginButton_Clicked(System.Object sender, System.EventArgs e)
        {

            Account.CurrentUser = new Account(EmailEntry.Text, PasswordEntry.Text);

            switch (AccountRepository.TryLogin(EmailEntry.Text, PasswordEntry.Text))
            {

                case LoginResult.NoEmail:
                    DisplayAlert("Error", "Email Does Not Exist", "OK");
                    break;
                case LoginResult.IncorrectPassword:
                    DisplayAlert("Error", "Password is incorrect", "OK");
                    break;
                default:
                    Navigation.PushAsync(new MainPage());
                    break;

            }





        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }
    }
}
