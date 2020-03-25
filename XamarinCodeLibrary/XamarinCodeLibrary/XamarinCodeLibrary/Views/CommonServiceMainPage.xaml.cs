using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCodeLibrary.CommonServices.EssentialServices;
using XamarinCodeLibrary.Models;

namespace XamarinCodeLibrary.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CommonServiceMainPage : ContentPage
    {
        public CommonServiceMainPage()
        {
            InitializeComponent();
        }


        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;

            if (sender is ListView lv) lv.SelectedItem = null;

            switch ((e.SelectedItem as CommonServiceModel).ServiceName)
            {
                case "Accelerometer":
                    Navigation.PushAsync(new AccelerometerPage());
                    break;
                case "App Information":
                    Navigation.PushAsync(new AppInfoPage());
                    break;
                case "App Theme":
                    Navigation.PushAsync(new AppThemePage());
                    break;
                case "Barometer":
                    Navigation.PushAsync(new BarometerPage());
                    break;
            }

        }

    }
}