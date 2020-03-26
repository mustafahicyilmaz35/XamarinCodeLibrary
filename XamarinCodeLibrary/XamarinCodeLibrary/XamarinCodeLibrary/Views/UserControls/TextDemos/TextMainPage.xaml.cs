using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.Views.UserControls.TextDemos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextMainPage : ContentPage
    {
        public TextMainPage()
        {
            InitializeComponent();

            List<Page> pages = new List<Page>();
            pages.Add(new EditorPage());

            pages.Add(new EntryPage());

            pages.Add(new LabelPage());

            pages.Add(new LoginPageXaml());

            pages.Add(new OrderPageXaml());

            pages.Add(new BuiltInStylesXaml());
            pages.Add(new CustomStylesXaml());

            ListOfPages.ItemsSource = pages;

        }

        private async void itemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await this.Navigation.PushAsync((Page)e.SelectedItem);
            }
            ListOfPages.SelectedItem = null;
        }
    }
}