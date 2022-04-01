using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace transCA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateBookingPage : ContentPage
    {
        private Destination _dest; 
        private Transportation _transport;
        public CreateBookingPage()
        {
            InitializeComponent();
        }

        private void DestinationPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dest = new Destination(DestinationPicker.SelectedItem.ToString().ToLower());
            PlaneCost.Text = $"${_dest.DestinationInfo[1]}";
            TrainCost.Text = $"${_dest.DestinationInfo[2]}";
            TourBusCost.Text = $"${_dest.DestinationInfo[3]}";

        }

        private void TransportationPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TransportationPicker.SelectedItem.ToString() == "Plane")
            {
                _transport = new Plane();
            }

        }

        private void PassengerPicker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}