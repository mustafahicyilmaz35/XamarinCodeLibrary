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
    public partial class BasicSliderPage : ContentPage
    {
        public BasicSliderPage()
        {
            InitializeComponent();
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            rotatingLabel.Rotation = value;
            displayLabel.Text = String.Format("The Slider value is {0}", value);
        }
    }
}