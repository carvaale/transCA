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
        public static List <Booking> _currentBookings;

        public ExistingBooking()
        {
            InitializeComponent();
        }

        public static void AddBooking(Booking booking)
        {
            _currentBookings.Add(booking);  
        }
    }
}