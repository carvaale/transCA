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
        private Account _user;
        private Booking _bookInfo;

        public BookingConfirmedPage(Account user, Booking book)
        {
            InitializeComponent();
            _user = user;
            _bookInfo = book;
            Confirmation();
            TicketQR.Source = ImageSource.FromResource($"transCA.Images.qr_ticket.png", typeof(BookingConfirmedPage));
        }

        
        private void Confirmation()
        {
            new ExistingBooking(_bookInfo);
            Confirm.Text = $"Congratulations ! Your trip to via has been booked for . Please keep the pass below for boarding. To view this pass again click 'Current Bookings' on the Home Page.";
        }

        private void Home_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage(_user));
        }
    }
}