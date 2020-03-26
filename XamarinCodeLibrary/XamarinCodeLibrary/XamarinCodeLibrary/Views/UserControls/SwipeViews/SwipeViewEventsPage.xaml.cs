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
    public partial class SwipeViewEventsPage : ContentPage
    {
        public SwipeViewEventsPage()
        {
            InitializeComponent();
        }

        private void OnSwipeStarted(object sender, SwipeStartedEventArgs e)
        {
            Console.WriteLine($"\tSwipeStarted: Direction - {e.SwipeDirection}");
        }

        private void OnSwipeChanging(object sender, SwipeChangingEventArgs e)
        {
            Console.WriteLine($"\tSwipeChanging: Direction - {e.SwipeDirection}, Offset - {e.Offset}");
        }

        private void OnSwipeEnded(object sender, SwipeEndedEventArgs e)
        {
            Console.WriteLine($"\tSwipEnded: Direction - {e.SwipeDirection}");
        }

        private void OnCloseRequested(object sender, EventArgs e)
        {
            Console.WriteLine("\tCloseRequested.");
        }

        private async void OnFavoriteSwipeItemInvoked(object sender, EventArgs e)
        {
            await DisplayAlert("SwipeView", "Favorite invoked.", "OK");
        }

        private async void OnDeleteSwipeItemInvoked(object sender, EventArgs e)
        {
            await DisplayAlert("SwipeView", "Delete invoked.", "OK");
        }

        private void OnCloseButtonClicked(object sender, EventArgs e)
        {
            swipeView.Close();
        }

    }
}