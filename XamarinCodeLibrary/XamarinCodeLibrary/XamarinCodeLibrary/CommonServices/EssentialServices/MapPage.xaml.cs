using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.CommonServices.EssentialServices
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
        }

        private async void ButtonOpenCoords_OnClicked(object sender, EventArgs e)
        {
            if(!double.TryParse(EntryLatitude.Text, out double lat))
                return;
            if(!double.TryParse(EntryLongtitude.Text,out double lng))
                return;
            await Map.OpenAsync(lat, lng, new MapLaunchOptions
            {
                Name = EntryName.Text,
                NavigationMode = NavigationMode.None
            });
        }
    }
}