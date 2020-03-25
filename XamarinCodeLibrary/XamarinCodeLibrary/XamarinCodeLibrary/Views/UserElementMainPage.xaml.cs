
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCodeLibrary.Models;
using XamarinCodeLibrary.Views.LayoutViews;
using XamarinCodeLibrary.Views.PageViews.CarouselPages;
using XamarinCodeLibrary.Views.PageViews.ContentPages;
using XamarinCodeLibrary.Views.PageViews.MasterDetailPages;
using XamarinCodeLibrary.Views.PageViews.ModalPages;
using XamarinCodeLibrary.Views.PageViews.NavigationPages;
using XamarinCodeLibrary.Views.PageViews.TabbedPages;
using XamarinCodeLibrary.Views.UserControls;
using XamarinCodeLibrary.Views.UserControls.ButtonViews;
using XamarinCodeLibrary.Views.UserControls.CarouselViews;
using XamarinCodeLibrary.Views.UserControls.CheckBoxes;
using XamarinCodeLibrary.Views.UserControls.CollectionViews;
using XamarinCodeLibrary.Views.UserControls.DatePickers;
using XamarinCodeLibrary.Views.UserControls.Frames;
using XamarinCodeLibrary.Views.UserControls.ListViews;

namespace XamarinCodeLibrary.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserElementMainPage : ContentPage
    {
        public UserElementMainPage()
        {
            InitializeComponent();
        }

        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //ListView de seçtiğimiz bir öğeyi tekrar seçebilmemiz için bu kod parçacığını kullanıyoruz.
            if (e.SelectedItem == null) return;

            if (sender is ListView lv) lv.SelectedItem = null;

            switch ((e.SelectedItem as UIModel)?.Name)
            {

                case "Content Page":
                    await Navigation.PushAsync(new ContentPageSampleView());
                    break;
                case "Master Detail Page":
                    await Navigation.PushAsync(new MasterDetailPageSampleView());
                    break;
                case "Navigation Page":
                    await Navigation.PushAsync(new NavigationPageSampleView());
                    break;
                case "Tabbed Page":
                    await Navigation.PushAsync(new TabbedPageSimpleView());
                    break;
                case "Carousel Page":
                    await Navigation.PushAsync(new CarouselPageSimpleView());
                    break;
                case "Modal Page":
                    await Navigation.PushAsync(new ModalPageSampleView());
                    break;
                case "Stack Layout":
                    await Navigation.PushAsync(new StackLayoutSampleView());
                    break;
                case "Relative Layout":
                    await Navigation.PushAsync(new RelativeLayoutSampleView());
                    break;
                case "Absolute Layout":
                    await Navigation.PushAsync(new AbsoluteLayoutSimpleView());
                    break;
                case "Grid":
                    await Navigation.PushAsync(new GridSampleView());
                    break;
                case "Flex Layout":
                    await Navigation.PushAsync(new FlexLayoutSampleView());
                    break;
                //case "Image":
                //    await Navigation.PushAsync(new ImageSampleView());
                //    break;
                //case "BoxView":
                //    await Navigation.PushAsync(new BoxViewSampleView());
                //    break;
                //case "WebView":
                //    await Navigation.PushAsync(new WebViewSampleView());
                //    break;
                //case "OpenGLView":
                //    await Navigation.PushAsync(new OpenGLSampleView()); //Block
                //    break;
                case "Button":
                    await Navigation.PushAsync(new ButtonViewSample());
                    break;
                case "ImageButton":
                    await Navigation.PushAsync(new ImageButtonSimpleView());
                    break;
                case "CheckBox":
                    await Navigation.PushAsync(new CheckBoxSampleView());
                    break;
               /* case "Slider":
                    await Navigation.PushAsync(new SliderSampleView());
                    break;
                case "Stepper":
                    await Navigation.PushAsync(new StepperSampleView());
                    break;
                case "Map":
                    await Navigation.PushAsync(new MapSampleViews());
                    break;
                case "Media Element":
                    await Navigation.PushAsync(new MediaSampleView());
                    break;
                case "RefreshView":
                    await Navigation.PushAsync(new RefreshViewSample());
                    break;
                case "SearchBar":
                    await Navigation.PushAsync(new SearchBarSampleView());
                    break;
                case "SwipeView":
                    await Navigation.PushAsync(new SwipeViewSample());
                    break;
                case "Switch":
                    await Navigation.PushAsync(new SwitchSampleView());
                    break;*/
                case "Date Picker":
                    await Navigation.PushAsync(new DatePickerSampleView());
                    break;
                //case "Text Demos":
                //    await Navigation.PushAsync(new TextMainPage());
                //    break;
                case "Activity Indicator":
                    await Navigation.PushAsync(new ActivityIndicatorSampleView());
                    break;
                //case "ProgressBar":
                //    await Navigation.PushAsync(new ProgressBarSampleView());
                //    break;
                case "CarouselView":
                    await Navigation.PushAsync(new CarouselViewSample());
                    break;
                case "CollectionView":
                    await Navigation.PushAsync(new CollectionSampleView());
                    break;
                //case "IndicatorView":
                //    await Navigation.PushAsync(new IndicatorViewSample()); //Block
                //    break;
                case "ListView":
                    await Navigation.PushAsync(new ListViewSampleView());
                    break;
                //case "Picker":
                //    await Navigation.PushAsync(new PickerViewSample());
                //    break;
                //case "TableView":
                //    await Navigation.PushAsync(new TableViewSample());
                //    break;
                case "Frame":
                    await Navigation.PushAsync(new FrameSample());
                    break;
                //case "ScrollView":
                //    await Navigation.PushAsync(new ScrolViewSample());
                //    break;
            }
        }
    }
}