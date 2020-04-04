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
    public partial class UnitConverterPage : ContentPage
    {
        public UnitConverterPage()
        {
            InitializeComponent();
        }

        private void ButtonCalculate_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(EntryValue.Text, out int val))
            {
                var mile = UnitConverters.KilometersToMiles(val);
                var cel = UnitConverters.FahrenheitToCelsius(val);
                LabelValue.Text = $"Miles: {mile}, Celsius: {cel}";
            }
        }
    }
}