using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.Views.UserControls.TextDemos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabelPage : ContentPage
    {
        public ICommand TapCommand { get; private set; }

        public LabelPage()
        {
            InitializeComponent();
            TapCommand = new Command(async () => await DisplayAlert("Tapped", "This is a tapped Span.", "OK"));
            BindingContext = this;
        }

        private void OnLineHeightChanged(object sender, TextChangedEventArgs e)
        {
            var lineHeight = ((Entry)sender).Text;
            try
            {
                _lineHeightLabel.LineHeight = double.Parse(lineHeight);
            }
            catch (FormatException ex)
            {
                Debug.WriteLine($"Can't parse {lineHeight}. {ex.Message}");
            }
        }
    }
}