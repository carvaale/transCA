using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace transCA
{
    public partial class MainPage : ContentPage
    {
        private Account _account;

        public MainPage(Account user)
        {
            InitializeComponent();
            _account = user;
        }

        private void ExistingBookingButton_Clicked(object sender, EventArgs e)
        {
        }

        private void CreateBookingButton_Clicked(object sender, EventArgs e)
        {
           
            Navigation.PushAsync(new CreateBookingPage(_account));

        }

        private void AddFundsButton_Clicked(object sender, EventArgs e)
        {
           // Navigation.PushAsync(new AddFundsPage());

        }
    }
}
