using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.Views.LayoutViews.ControlViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControlViewPage : ContentPage
    {
        public ICommand NavigateCommand { get; set; }
        public ControlViewPage()
        {
            InitializeComponent();

            NavigateCommand = new Command<Type>(async (Type pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await Navigation.PushAsync(page);
            });

            BindingContext = this;
        }

    }
}