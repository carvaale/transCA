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
    public partial class InsufficientFundsPage : ContentPage
    {
        private Account _user;
        public InsufficientFundsPage(Account user)
        {
            InitializeComponent();
            _user = user;
        }

        private void AddFunds_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddFundsPage());
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage(_user));
        }
    }
}