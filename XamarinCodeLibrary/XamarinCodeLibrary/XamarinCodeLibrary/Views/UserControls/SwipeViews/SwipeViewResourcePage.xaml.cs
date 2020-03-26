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
    public partial class SwipeViewResourcePage : ContentPage
    {
        public SwipeViewResourcePage()
        {
            InitializeComponent();
        }
        private async void OnFavoriteSwipeItemInvoked(object sender, EventArgs e)
        {
            await DisplayAlert("SwipeView", "Delete invoked.", "OK");
        }

        private async void OnDeleteSwipeItemInvoked(object sender, EventArgs e)
        {
            await DisplayAlert("SwipeView", "Favorite invoked.", "OK");
        }
    }
}