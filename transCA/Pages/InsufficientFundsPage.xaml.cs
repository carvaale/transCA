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
        public InsufficientFundsPage()
        {
            InitializeComponent();
            _user = Account.CurrentUser;
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