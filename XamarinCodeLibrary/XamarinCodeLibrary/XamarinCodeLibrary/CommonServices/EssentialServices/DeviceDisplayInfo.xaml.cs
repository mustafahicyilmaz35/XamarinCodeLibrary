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
    public partial class DeviceDisplayInfo : ContentPage
    {
        public DeviceDisplayInfo()
        {
            InitializeComponent();
            DeviceDisplay.MainDisplayInfoChanged += OnMainDisplayInfoChanged;
            //DeviceDisplay.KeepScreenOn = !DeviceDisplay.KeepScreenOn;
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            Orientation.Text = "Orientation: "+ mainDisplayInfo.Orientation.ToString();
            Rotation.Text = "Rotation: " + mainDisplayInfo.Rotation.ToString();
            WithLabel.Text = "Width: " + mainDisplayInfo.Width.ToString();
            HighLabel.Text = "High: " + mainDisplayInfo.Height.ToString();
            Density.Text = "Density: " + mainDisplayInfo.Density.ToString();

        }

        private void OnMainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            var displayInfo = e.DisplayInfo;
        }

    }
}