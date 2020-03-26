using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.Views.UserControls.TableViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TableViewSample : ContentPage
    {
        public TableViewSample()
        {
            InitializeComponent();
        }

        private void OnViewCellTapped(object sender, EventArgs e)
        {
            _target.IsVisible = !_target.IsVisible;
            _viewCell.ForceUpdateSize();
        }
    }
}