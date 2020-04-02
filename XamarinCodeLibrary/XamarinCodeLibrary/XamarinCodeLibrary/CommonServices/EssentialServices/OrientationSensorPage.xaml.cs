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
    public partial class OrientationSensorPage : ContentPage
    {

        SensorSpeed speed = SensorSpeed.UI;

        public OrientationSensorPage()
        {
            InitializeComponent();
            OrientationSensor.ReadingChanged += OrientationSensor_ReadingChanged;
        }

        void OrientationSensor_ReadingChanged(object sender, OrientationSensorChangedEventArgs e)
        {
            var data = e.Reading;
            //Console.WriteLine($"Reading: X: {data.Orientation.X}, Y: {data.Orientation.Y}, Z: {data.Orientation.Z}, W: {data.Orientation.W}");
            // Process Orientation quaternion (X, Y, Z, and W)
            LabelX.Text = data.Orientation.X.ToString();
            LabelY.Text = data.Orientation.Y.ToString();
            LabelZ.Text = data.Orientation.Z.ToString();
            LabelW.Text = data.Orientation.W.ToString();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            try
            {
                if (OrientationSensor.IsMonitoring)
                    OrientationSensor.Stop();
                else
                    OrientationSensor.Start(speed);
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