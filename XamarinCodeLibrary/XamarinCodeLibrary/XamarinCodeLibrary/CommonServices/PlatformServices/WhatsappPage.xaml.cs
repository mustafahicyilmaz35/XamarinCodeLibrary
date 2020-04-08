using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.OpenWhatsApp;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.CommonServices.PlatformServices
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WhatsappPage : ContentPage
    {
        public WhatsappPage()
        {
            InitializeComponent();
        }

        private void Button_Send_Clicked(object sender, EventArgs e)
        {
            try
            {
                Chat.Open(EntryNumber.Text,EntryMessage.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private void Button_Cancel_Clicked_(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PlatformServicesMainPage());
        }
    }
}