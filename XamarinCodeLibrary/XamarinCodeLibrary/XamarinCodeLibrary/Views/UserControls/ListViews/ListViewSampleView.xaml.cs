using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCodeLibrary.Views.UserControls.ListViews.Basic;

namespace XamarinCodeLibrary.Views.UserControls.ListViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewSampleView : ContentPage
    {
        public ListViewSampleView()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BasicList());
        }

        private async void Context_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContextAction.ContextAction());
        }
    }
}