using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.Views.UserControls.Switchs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwitchXamlPage : ContentPage
    {
        public SwitchXamlPage()
        {
            InitializeComponent();
        }

        private void XAMLSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            string stateName = e.Value ? "ON" : "OFF";
            switchStateLabel.Text = $"The switch is {stateName}";
        }
    }
}