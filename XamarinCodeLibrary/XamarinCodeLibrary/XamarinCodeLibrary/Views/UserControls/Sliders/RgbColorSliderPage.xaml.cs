using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.Views.UserControls.Sliders
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RgbColorSliderPage : ContentPage
    {
        public RgbColorSliderPage()
        {
            InitializeComponent();
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (sender == redSlider)
            {
                redLabel.Text = String.Format("Red = {0:X2}", (int)e.NewValue);
            }
            else if (sender == greenSlider)
            {
                greenLabel.Text = String.Format("Green = {0:X2}", (int)e.NewValue);
            }
            else if (sender == blueSlider)
            {
                blueLabel.Text = String.Format("Blue = {0:X2}", (int)e.NewValue);
            }

            boxView.Color = Color.FromRgb((int)redSlider.Value,
                (int)greenSlider.Value,
                (int)blueSlider.Value);
        }
    }
}