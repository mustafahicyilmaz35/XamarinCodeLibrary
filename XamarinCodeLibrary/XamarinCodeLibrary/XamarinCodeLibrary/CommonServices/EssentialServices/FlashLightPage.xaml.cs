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
    public partial class FlashLightPage : ContentPage
    {
        public FlashLightPage()
        {
            InitializeComponent();
        }

        private async void ButtonOn_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Xamarin.Essentials.Flashlight.TurnOnAsync();
                DisplayAlert("Mesaj", "Lamba Yandı", "OK");
            }
            catch (Exception exception)
            {
                DisplayAlert("HATA", exception.Message, "OK");
            }

        }

        private async void ButtonOff_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Flashlight.TurnOffAsync();
                DisplayAlert("Mesaj", "Lamba Söndü", "OK");

            }
            catch (Exception exception)
            {
                DisplayAlert("HATA", "Donanım Bulunamadı", "OK");
            }
        }
    }
}