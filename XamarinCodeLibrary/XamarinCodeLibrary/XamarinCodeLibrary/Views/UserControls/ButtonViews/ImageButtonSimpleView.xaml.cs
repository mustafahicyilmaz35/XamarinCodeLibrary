using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.Views.UserControls.ButtonViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageButtonSimpleView : ContentPage
    {
        public ImageButtonSimpleView()
        {
            InitializeComponent();
        }

        private void ImageButton_OnClicked(object sender, EventArgs e)
        {
            MyButton.IsVisible = true;
        }
    }
}