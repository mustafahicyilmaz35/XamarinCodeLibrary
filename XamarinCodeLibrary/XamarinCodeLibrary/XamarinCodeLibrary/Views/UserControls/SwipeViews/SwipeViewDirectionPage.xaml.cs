using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.Views.UserControls.SwipeViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipeViewDirectionPage : ContentPage
    {
        public SwipeViewDirectionPage()
        {
            InitializeComponent();
        }

        private async void OnFavoriteSwipeItemInvoked(object sender, EventArgs e)
        {
            await DisplayAlert("SwipeView", "Favorite invoked.", "OK");
        }

        private async void OnDeleteSwipeItemInvoked(object sender, EventArgs e)
        {
            await DisplayAlert("SwipeView", "Share invoked.", "OK");
        }

        private async void OnShareSwipeItemInvoked(object sender, EventArgs e)
        {
            await DisplayAlert("SwipeView", "Delete invoked.", "OK");
        }
    }
}