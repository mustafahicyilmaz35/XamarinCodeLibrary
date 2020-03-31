using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.CommonServices.EssentialServices
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceInfo : ContentPage
    {
        public DeviceInfo()
        {
            InitializeComponent();
            LabelDeviceInfo.Text = "Model: " + Xamarin.Essentials.DeviceInfo.Model;
            LabelDeviceType.Text ="Type: " + Xamarin.Essentials.DeviceInfo.DeviceType.ToString();
            LabelIdiom.Text ="Idiom: " + Xamarin.Essentials.DeviceInfo.Idiom.ToString();
            LabelManufacturer.Text = "Manufacturer: " +Xamarin.Essentials.DeviceInfo.Manufacturer;
            LabelOperationSystem.Text ="Operation System Version: " + Xamarin.Essentials.DeviceInfo.VersionString;
            LabelPlatform.Text = "Platform: " + Xamarin.Essentials.DeviceInfo.Platform.ToString();
            LabelDeviceType.Text = "Device Type: " + Xamarin.Essentials.DeviceInfo.DeviceType.ToString();

        }
    }
}