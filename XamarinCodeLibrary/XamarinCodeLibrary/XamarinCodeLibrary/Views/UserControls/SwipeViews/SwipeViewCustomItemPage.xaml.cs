using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.Views.UserControls.SwipeViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipeViewCustomItemPage : ContentPage
    {
        public ICommand CheckAnswerCommand { get; private set; }

        public SwipeViewCustomItemPage()
        {
            InitializeComponent();

            CheckAnswerCommand = new Command<string>(CheckAnswer);
            BindingContext = this;
        }

        private async void OnIncorrectAnswerInvoked(object sender, EventArgs e)
        {
            await DisplayAlert("Incorrect!", "Try again.", "OK");
        }

        private async void OnCorrectAnswerInvoked(object sender, EventArgs e)
        {
            await DisplayAlert("Correct!", "The answer is 2.", "OK");
        }


        void CheckAnswer(string result)
        {
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(resultEntry.Text);
                if (number.Equals(2))
                    OnCorrectAnswerInvoked(swipeView2, EventArgs.Empty);
                else
                    OnIncorrectAnswerInvoked(swipeView2, EventArgs.Empty);
            }
        }

    }
}