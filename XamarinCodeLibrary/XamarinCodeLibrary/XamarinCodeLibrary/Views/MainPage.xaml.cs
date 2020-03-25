using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinCodeLibrary.CommonServices.PlatformServices;
using XamarinCodeLibrary.Views;

namespace XamarinCodeLibrary
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserElementMainPage());
        }

        private async void Button2_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CommonServiceMainPage());
        }

        private async void Button3_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlatformServicesMainPage());
        }
    }
}
