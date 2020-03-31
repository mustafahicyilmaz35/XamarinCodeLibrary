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
    public partial class GyroscopePage : ContentPage
    {
        SensorSpeed speed = SensorSpeed.UI;
        public GyroscopePage()
        {
            InitializeComponent();
            Gyroscope.ReadingChanged += Gyroscope_ReadingChanged;
        }

        void Gyroscope_ReadingChanged(object sender, GyroscopeChangedEventArgs e)
        {
            var data = e.Reading;
            // Process Angular Velocity X, Y, and Z reported in rad/s
            //Console.WriteLine($"Reading: X: {data.AngularVelocity.X}, Y: {data.AngularVelocity.Y}, Z: {data.AngularVelocity.Z}");
            LabelX.Text = data.AngularVelocity.X.ToString();
            LabelY.Text = data.AngularVelocity.Y.ToString();
            LabelZ.Text = data.AngularVelocity.Z.ToString();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            try
            {
                if (Gyroscope.IsMonitoring)
                    Gyroscope.Stop();
                else
                    Gyroscope.Start(speed);
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