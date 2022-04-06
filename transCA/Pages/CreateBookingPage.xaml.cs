﻿using System;
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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateBookingPage : ContentPage
    {
        private Destination _dest; 
        private Transportation _transport;
        private Account _userAccount;
        private Booking _bookInfo;
        public CreateBookingPage(Account user)
        {
            InitializeComponent();
            _userAccount = user;
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
                Cost.Text = $"${_transport.GetTotal()}";
                Arrival.Text = _transport.GetArrival().ToString("MM/dd/yyyy");
            }
            if (TransportationPicker.SelectedItem.ToString() == "Train")
            {
                _transport = new Train(_dest, Int32.Parse(PassengerPicker.SelectedItem.ToString()));
                Cost.Text = $"${_transport.GetTotal()}";
                Arrival.Text = _transport.GetArrival().ToString("MM/dd/yyyy");
            }
            if (TransportationPicker.SelectedItem.ToString() == "Tour Bus") 
            {
                _transport = new TouringBus(_dest, Int32.Parse(PassengerPicker.SelectedItem.ToString()));
                Cost.Text = $"${_transport.GetTotal()}";
                Arrival.Text = _transport.GetArrival().ToString("MM/dd/yyyy");
            }

            TransportationPicker.IsEnabled = false;
        }

        private void Confirm_Clicked(object sender, EventArgs e)
        {
            if (_userAccount.CheckBalance(double.Parse(Cost.Text)))
            {
                _bookInfo.DestinationRequired = _dest;
                _bookInfo.TransportationDetails = _transport;
                _bookInfo.ProvinceName = DestinationPicker.SelectedItem.ToString();
                Navigation.PushAsync(new BookingConfirmedPage(_userAccount,_bookInfo));
               // Destination dest = _dest;
               // Transportation transport = _transport;
               // new ExistingBooking(dest, transport, DestinationPicker.SelectedItem.ToString());
            }

            Navigation.PushAsync(new InsufficientFundsPage(_userAccount));
               
        }
    }
}