using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using transCA.Backend;
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
            TicketQR.Source = ImageSource.FromResource($"transCA.Images.qr_ticket.png", typeof(BookingConfirmedPage));
        }

        
        private void Confirmation()
        {
            //Confirm.Text = $"Congratulations {Account.CurrentUser._userName}! Your trip to {_trip.ProvinceName} via {_trip.TransportationDetails} has been booked for {_trip.DestinationRequired}. Please keep the pass below for boarding. To view this pass again click 'Current Bookings' on the Home Page.";
        }

        private void Home_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}