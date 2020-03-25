using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XamarinCodeLibrary.Annotations;
using XamarinCodeLibrary.Models;

namespace XamarinCodeLibrary.ViewModels
{
    public class UserElementMainPageViewModel : INotifyPropertyChanged
    {


        private List<UIModel> _myUserUI;

        public List<UIModel> MyUserUI
        {
            get => _myUserUI;
            set
            {
                _myUserUI = value;
                OnPropertyChanged(nameof(_myUserUI));
            }

        }


        //public ICommand ContentPageCommand => new Command(GoToContentPageSampleAsync);

        //private async void GoToContentPageSampleAsync()
        //{
        //    await Application.Current.MainPage.Navigation.PushAsync(new ContentPageSampleView());
        //}


        public UserElementMainPageViewModel()
        {
            MyUserUI = new List<UIModel>
            {

                new UIModel{UIType = "Layout", Name = "Stack Layout"},
                new UIModel{UIType = "Layout", Name = "Relative Layout"},
                new UIModel{UIType = "Layout", Name = "Absolute Layout"},
                new UIModel{UIType = "Layout", Name = "Grid"},
                new UIModel{UIType = "Layout", Name = "Flex Layout"},
                new UIModel{UIType = "Page", Name = "Content Page"},
                new UIModel{UIType = "Page", Name = "Master Detail Page"},
                new UIModel{UIType = "Page", Name = "Navigation Page"},
                new UIModel{UIType = "Page", Name = "Tabbed Page"},
                new UIModel{UIType = "Page", Name = "Carousel Page"},
                new UIModel{UIType = "Page", Name = "Modal Page"},
                new UIModel{UIType = "View", Name = "Image"},
                new UIModel{UIType = "View", Name = "BoxView"},
                new UIModel{UIType = "View", Name = "WebView"},
                new UIModel{UIType = "View", Name = "OpenGLView"}, // Advanced
                new UIModel{UIType = "View", Name = "Map"},
                new UIModel{UIType = "View", Name = "Media Element"},
                new UIModel{UIType = "View", Name = "Button"},
                new UIModel{UIType = "View", Name = "ImageButton"},
                new UIModel{UIType = "View", Name = "RefreshView"},
                new UIModel{UIType = "View", Name = "SearchBar"},
                new UIModel{UIType = "View", Name = "SwipeView"},
                new UIModel{UIType = "View", Name = "CheckBox"},
                new UIModel{UIType = "View", Name = "Slider"},
                new UIModel{UIType = "View", Name = "Stepper"},
                new UIModel{UIType = "View", Name = "Switch"},
                new UIModel{UIType = "View", Name = "Date Picker"},
                new UIModel{UIType = "View", Name = "Text Demos"},
                new UIModel{UIType = "View", Name = "Activity Indicator"},
                new UIModel{UIType = "View", Name = "ProgressBar"},
                new UIModel{UIType = "View", Name = "CarouselView"},
                new UIModel{UIType = "View", Name = "CollectionView"},
                new UIModel{UIType = "View", Name = "IndicatorView"},
                new UIModel{UIType = "View", Name = "ListView"},
                new UIModel{UIType = "View", Name = "Picker"},
                new UIModel{UIType = "View", Name = "TableView"},
                new UIModel{UIType = "View", Name = "Frame"},
                new UIModel{UIType = "View", Name = "ScrollView"},


            };
        }




        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
