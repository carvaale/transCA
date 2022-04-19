using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using transCA.Backend;
using transCA.Pages;

namespace transCA
{
    // Alexander Carvalho and Klajdi Hoxhalli
    // Creates a booking with destination, transportation, and arricval time info

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateBookingPage : ContentPage
    {
        private Destination _dest; 
        private Transportation _transport;
        private Booking _bookInfo;
        public CreateBookingPage()
        {
            InitializeComponent();
            DestinationPicker.IsEnabled = false;
            TransportationPicker.IsEnabled = false;

        }

        private void PassengerPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            PassengerPicker.IsEnabled = false;
            DestinationPicker.IsEnabled = true;
        }

        private void DestinationPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dest = new Destination(DestinationPicker.SelectedItem.ToString());
            PlaneCost.Text = $"${_dest.DestinationInfo[1]}/ea";
            TrainCost.Text = $"${_dest.DestinationInfo[2]}/ea";
            TourBusCost.Text = $"${_dest.DestinationInfo[3]}/ea";

            DestinationPicker.IsEnabled = false;
            TransportationPicker.IsEnabled = true;
        }

        private void TransportationPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TransportationPicker.SelectedItem.ToString() == "Plane")
            {
                _transport = new Plane(_dest, Int32.Parse(PassengerPicker.SelectedItem.ToString()));
                Cost.Text = $"{_transport.GetTotal()}";
                Arrival.Text = _transport.GetArrival().ToString("MM/dd/yyyy");
            }
            if (TransportationPicker.SelectedItem.ToString() == "Train")
            {
                _transport = new Train(_dest, Int32.Parse(PassengerPicker.SelectedItem.ToString()));
                Cost.Text = $"{_transport.GetTotal()}";
                Arrival.Text = _transport.GetArrival().ToString("MM/dd/yyyy");
            }
            if (TransportationPicker.SelectedItem.ToString() == "Tour Bus") 
            {
                _transport = new TouringBus(_dest, Int32.Parse(PassengerPicker.SelectedItem.ToString()));
                Cost.Text = $"{_transport.GetTotal()}";
                Arrival.Text = _transport.GetArrival().ToString("MM/dd/yyyy");
            }

            TransportationPicker.IsEnabled = false;
        }

        private void Confirm_Clicked(object sender, EventArgs e)
        {
            if (Account.CurrentUser.CheckBalance(Int32.Parse(Cost.Text)))
            {
                _bookInfo = new Booking(_dest, _transport, DestinationPicker.SelectedItem.ToString(), TransportationPicker.SelectedItem.ToString());
                /*  _bookInfo.DestinationRequired = _dest;
                  _bookInfo.TransportationDetails = _transport;
                  _bookInfo.ProvinceName = DestinationPicker.SelectedItem.ToString(); */
                  ExistingBooking.AddBooking(_bookInfo);

                Navigation.PushAsync(new BookingConfirmedPage(_bookInfo));
            }
            else
            {
                Navigation.PushAsync(new InsufficientFundsPage());
            }
        }
    }
}