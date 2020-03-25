using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.Views.PageViews.MasterDetailPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPageSampleView : MasterDetailPage
    {
        public List<MasterDetailItem> menuList;
        public MasterDetailPageSampleView()
        {
            InitializeComponent();

            menuList = new List<MasterDetailItem>();
            menuList.Add(new MasterDetailItem
            {
                Title = "First Page",
                Icon = "first.png",
                PageType = typeof(FirstPage)
            });
            menuList.Add(new MasterDetailItem
            {
                Title = "Second Page",
                Icon = "first.png",
                PageType = typeof(SecondPage)
            });
            menuList.Add(new MasterDetailItem
            {
                Title = "Third Page",
                Icon = "first.png",
                PageType = typeof(ThirdPage)
            });
            listView.ItemsSource = menuList;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(FirstPage)));

        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailItem;
            Type page = item.PageType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}