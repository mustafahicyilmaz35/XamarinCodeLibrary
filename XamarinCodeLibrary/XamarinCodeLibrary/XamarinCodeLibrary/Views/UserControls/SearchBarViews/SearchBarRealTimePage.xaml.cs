using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCodeLibrary.ViewModels.SearchViewModels;

namespace XamarinCodeLibrary.Views.UserControls.SearchBarViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchBarRealTimePage : ContentPage
    {
        public SearchBarRealTimePage()
        {
            InitializeComponent();
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            searchResults.ItemsSource = DataService.GetSearchResults(e.NewTextValue);
        }
    }
}