using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCodeLibrary.CommonServices.EssentialServices
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SharedPreferencePage : ContentPage
    {
        
        public SharedPreferencePage()
        {
            InitializeComponent();
            LabelName.Text = Preferences.Get("userName", "");


        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            AddValue("userName",EntryName.Text);
            LabelName.Text = Preferences.Get("userName", "");
            DisplayAlert("Kaydedildi", "İsim " + LabelName.Text + " olarak kaydedildi.", "OK");



        }

        public void AddValue(string key, string value)
        {
            Preferences.Set(key,value);
        }

        private void DeletedButton(object sender, EventArgs e)
        {
            Preferences.Remove("userName");
            DisplayAlert("Silindi", "İsim silindi", "OK");
        }
    }
}