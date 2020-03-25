using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCodeLibrary.ViewModels.ListViewModels;

namespace XamarinCodeLibrary.Views.UserControls.ListViews.Basic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasicList : ContentPage
    {
        public BasicList()
        {
            InitializeComponent();
        }

        private void PersonListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;

            if (sender is ListView lv) lv.SelectedItem = null;
            string name = (e.SelectedItem as Person).Name;
            DisplayAlert("Merhaba", name, "OK");
        }

        private void Edit_OnClicked(object sender, EventArgs e)
        {
            var menuItemName = ((MenuItem)sender);
            DisplayAlert("Düzenle", menuItemName.CommandParameter.ToString(), "OK");
        }

        private void Delete_OnClicked(object sender, EventArgs e)
        {
            var menuItemName = ((MenuItem)sender);
            DisplayAlert("Sil", menuItemName.CommandParameter.ToString(), "OK");
        }
    }
}