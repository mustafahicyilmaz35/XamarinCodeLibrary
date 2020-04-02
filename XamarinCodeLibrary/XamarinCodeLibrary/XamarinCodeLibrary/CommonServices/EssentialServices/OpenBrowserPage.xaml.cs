using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.CommonServices.EssentialServices
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OpenBrowserPage : ContentPage
    {
        Uri uri;
        public OpenBrowserPage()
        {
            InitializeComponent();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        void btnOpenBrowser_Clicked(object sender, System.EventArgs e)
        {
            if (txtUrl.Text != null)
            {
                try
                {
                    uri = new Uri(txtUrl.Text);
                    OpenBrowser(uri);
                }
                catch (Exception exception)
                {
                    DisplayAlert("Hata", "Lütfen prtotokol bilgisi yazın(https://)", "OK");
                }
            }
            else
            {
                DisplayAlert("Hata", "Url Alanı boş bırakılamaz", "OK");
            }
        }

        public async void OpenBrowser(Uri uri)
        {
            await Browser.OpenAsync(uri, new BrowserLaunchOptions
            {
                LaunchMode = BrowserLaunchMode.SystemPreferred

                //TitleMode = BrowserTitleMode.Show,
                //PreferredToolbarColor = Color.AliceBlue,
                //PreferredControlColor = Color.Violet
            });
        }
    }
}