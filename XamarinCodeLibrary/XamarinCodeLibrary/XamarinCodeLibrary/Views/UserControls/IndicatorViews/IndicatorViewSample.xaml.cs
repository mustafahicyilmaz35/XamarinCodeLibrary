using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.Views.UserControls.IndicatorViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndicatorViewSample : ContentPage
    {
        public ICommand NavigateCommand { get; private set; }

        public IndicatorViewSample()
        {
            InitializeComponent();

            NavigateCommand = new Command<Type>(
                async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await Navigation.PushAsync(page);
                });

            BindingContext = this;
        }
    }
}
