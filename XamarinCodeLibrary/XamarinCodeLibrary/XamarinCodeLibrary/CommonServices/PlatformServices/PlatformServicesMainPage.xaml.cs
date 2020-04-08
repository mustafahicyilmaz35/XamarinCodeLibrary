using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.CommonServices.PlatformServices
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlatformServicesMainPage : ContentPage
    {
        public PlatformServicesMainPage()
        {
            InitializeComponent();
        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            if (e.SelectedItem == null) return;

            if (sender is ListView lv) lv.SelectedItem = null;

            switch ((e.SelectedItem as PlatformServiceModel)?.Name)
            {
                case "WhatsApp":
                    Navigation.PushAsync(new WhatsappPage());
                    break;
            }
        }
    }
}