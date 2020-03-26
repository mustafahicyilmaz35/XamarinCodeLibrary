using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using XamarinCodeLibrary.ViewModels.MapViewModels;

namespace XamarinCodeLibrary.Views.UserControls.MapViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PinItemsSourcePage : ContentPage
    {
        public PinItemsSourcePage()
        {
            InitializeComponent();
            BindingContext = new MapSampleViewModel();
            map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(39.8283459, -98.5794797), Distance.FromMiles(1500)));
        }

        private void OnMapClicked(object sender, MapClickedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"MapClick: {e.Position.Latitude}, {e.Position.Longitude}");
        }
    }
}