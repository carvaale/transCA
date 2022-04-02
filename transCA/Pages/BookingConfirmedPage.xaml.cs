using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace transCA.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookingConfirmedPage : ContentPage
    {
        public BookingConfirmedPage()
        {
            InitializeComponent();
            Confirmation();
        }

        private void Confirmation()
        {
            Confirm.Text = $"Congratulations ! Your trip to via has been booked for . Please keep the pass below for boarding. To view this pass again click 'Current Booking' on the Home Page.";
        }

        private void Home_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}