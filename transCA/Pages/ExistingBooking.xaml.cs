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
    // Klajdi Hoxhalli
    // Provides the opportunity to look at the bookings that the user does and to add more bookings 
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExistingBooking : ContentPage
    {
        private static List <Booking> _currentBookings = new List<Booking>();


        public ExistingBooking()
        {
            InitializeComponent();
            BookingList.ItemsSource = _currentBookings;

        }

        public static void AddBooking(Booking booking)
        {
            _currentBookings.Add(booking);
        }
        
        public static Booking GetRecentBooking()
        {
            return _currentBookings[0];
        }

        private void BookingList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var booking = BookingList.SelectedItem as Booking;
            Navigation.PushAsync(new BookingConfirmedPage(booking));
        }
    }
}
