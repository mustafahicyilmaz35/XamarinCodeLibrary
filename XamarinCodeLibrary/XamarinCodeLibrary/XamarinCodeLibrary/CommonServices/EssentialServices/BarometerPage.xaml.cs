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
    public partial class BarometerPage : ContentPage
    {

        SensorSpeed speed = SensorSpeed.UI;

        public BarometerPage()
        {
            InitializeComponent();
            Barometer.ReadingChanged += Barometer_ReaderChanged;
        }

        private void Barometer_ReaderChanged(object sender, BarometerChangedEventArgs e)
        {
            var data = e.Reading;
            LabelBarometer.Text = $"{data.PressureInHectopascals} hectopascals";
        }


        private void Button_OnClicked(object sender, EventArgs e)
        {
            try
            {
                if (Barometer.IsMonitoring)
                    Barometer.Stop();
                else
                    Barometer.Start(speed);
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature not supported on device
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }
    }
}