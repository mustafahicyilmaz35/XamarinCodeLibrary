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
    public partial class ClipBoardPage : ContentPage
    {
        public ClipBoardPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (EntryPin.Text == "1234")
                DisplayAlert("You did it!", "Pin was accepted!", "OK");
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (Clipboard.HasText)
            {
                var text = await Clipboard.GetTextAsync();
                if (text.Length == 4)
                    EntryPin.Text = text;
            }
        }
    }
}