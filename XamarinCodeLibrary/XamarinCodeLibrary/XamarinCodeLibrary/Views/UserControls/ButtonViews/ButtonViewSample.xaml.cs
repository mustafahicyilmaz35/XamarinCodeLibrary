using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.Views.UserControls.ButtonViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonViewSample : ContentPage
    {
        bool animationInProgress = false;
        Stopwatch stopwatch = new Stopwatch();

        public ButtonViewSample()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await label.RelRotateTo(360, 1000);
        }

        private void OnButtonPressed(object sender, EventArgs e)
        {
            stopwatch.Start();
            animationInProgress = true;

            Device.StartTimer(TimeSpan.FromMilliseconds(16), () =>
            {
                label.Rotation = 360 * (stopwatch.Elapsed.TotalSeconds % 1);

                return animationInProgress;
            });
        }

        private void OnButtonReleased(object sender, EventArgs e)
        {
            animationInProgress = false;
            stopwatch.Stop();
        }
    }
}