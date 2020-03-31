using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.CommonServices
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MagnometerPage : ContentPage
    {
        SensorSpeed speed = SensorSpeed.UI;
        public MagnometerPage()
        {
            InitializeComponent();
            Magnetometer.ReadingChanged += Magnetometer_ReadingChanged;
        }

        void Magnetometer_ReadingChanged(object sender, MagnetometerChangedEventArgs e)
        {
            var data = e.Reading;
            // Process MagneticField X, Y, and Z
            //Console.WriteLine($"Reading: X: {data.MagneticField.X}, Y: {data.MagneticField.Y}, Z: {data.MagneticField.Z}");
            LabelMagneticX.Text = data.MagneticField.X.ToString();
            LabelMagneticY.Text = data.MagneticField.Y.ToString();
            LabelMagneticZ.Text = data.MagneticField.Z.ToString();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            try
            {
                if (Magnetometer.IsMonitoring)
                    Magnetometer.Stop();
                else
                    Magnetometer.Start(speed);
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