using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.Views.UserControls.WebViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewSampleView : ContentPage
    {
        public WebViewSampleView()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LocalHtml());
        }
    }
}