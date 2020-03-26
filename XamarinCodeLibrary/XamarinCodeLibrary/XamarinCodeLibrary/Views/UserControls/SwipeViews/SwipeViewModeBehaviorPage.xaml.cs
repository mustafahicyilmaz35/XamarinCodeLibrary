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
    public partial class SwipeViewModeBehaviorPage : ContentPage
    {
        public SwipeViewModeBehaviorPage()
        {
            InitializeComponent();
        }

        private void OnSwipeViewModeChanged(object sender, EventArgs e)
        {
            swipeView1.LeftItems.Mode = (SwipeMode)(sender as EnumPicker).SelectedItem;
            swipeView2.LeftItems.Mode = (SwipeMode)(sender as EnumPicker).SelectedItem;
        }

        private void OnSwipeViewBehaviorChanged(object sender, EventArgs e)
        {
            swipeView1.LeftItems.SwipeBehaviorOnInvoked = (SwipeBehaviorOnInvoked)(sender as EnumPicker).SelectedItem;
            swipeView2.LeftItems.SwipeBehaviorOnInvoked = (SwipeBehaviorOnInvoked)(sender as EnumPicker).SelectedItem;
        }

        private async void OnDeleteSwipeItemInvoked(object sender, EventArgs e)
        {
            await DisplayAlert("SwipeView", "Delete invoked.", "OK");
        }

        private async void OnFavoriteSwipeItemInvoked(object sender, EventArgs e)
        {
            await DisplayAlert("SwipeView", "Favorite invoked.", "OK");
        }
    }
}