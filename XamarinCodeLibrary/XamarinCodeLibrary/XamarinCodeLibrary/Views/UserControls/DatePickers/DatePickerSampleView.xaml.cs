using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.Views.UserControls.DatePickers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePickerSampleView : ContentPage
    {
        public DatePickerSampleView()
        {
            InitializeComponent();
        }

        private void OnDateSelected(object sender, DateChangedEventArgs e)
        {
            Recalculate();
        }

        private void OnSwitchToggled(object sender, ToggledEventArgs e)
        {
            Recalculate();
        }

        void Recalculate()
        {
            TimeSpan timeSpan = endDatePicker.Date - startDatePicker.Date +
                                (includeSwitch.IsToggled ? TimeSpan.FromDays(1) : TimeSpan.Zero);

            resultLabel.Text = String.Format("{0} day{1} between dates",
                timeSpan.Days, timeSpan.Days == 1 ? "" : "s");
        }
    }
}