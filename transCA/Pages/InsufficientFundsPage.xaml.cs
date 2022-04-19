using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace transCA.Pages
{
    // Alexander Carvalho
    // Dsiplays when user does not have enough money for a trip
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InsufficientFundsPage : ContentPage
    {
        public InsufficientFundsPage()
        {
            InitializeComponent();
        }

        private void AddFunds_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddFundsPage());
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}