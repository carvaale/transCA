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
    public partial class ExistingBooking : ContentPage
    {
        private Booking _book;
        public ExistingBooking(Booking book )
        {
            InitializeComponent();
            _book = book;
            BookingDetails();

        }
        private void BookingDetails()
        {
            DestinationLabel.Text += $"{_book.ProvinceName}";
            // DepartureTimeLabel += $"{}";
            ArrivalTimeLabel.Text += $"{_book.TransportationDetails.GetArrival()}";
            //TripTimelabel.Text += $"{_book.DestinationRequired._distance / _book.DestinationRequired._speed}";
            PriceLabel.Text += $"{_book.TransportationDetails.GetTotal()}";
           
        }
    }
}