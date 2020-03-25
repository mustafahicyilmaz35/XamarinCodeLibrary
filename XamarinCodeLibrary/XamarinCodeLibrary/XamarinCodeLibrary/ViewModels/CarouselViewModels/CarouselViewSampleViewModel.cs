using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XamarinCodeLibrary.Annotations;

namespace XamarinCodeLibrary.ViewModels.CarouselViewModels
{

    public class CarouselViewSampleViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Birds> _mybirds;

        private string _pageTitle;

        public CarouselViewSampleViewModel()
        {
            _pageTitle = "CarouselViewChallege";
            _mybirds = new ObservableCollection<Birds>();
            _mybirds.Add(new Birds { Title = "Asian Paradise Flycatcher", ImagePath = "paradiseflycatcher.jpg" });
            _mybirds.Add(new Birds { Title = "Sarus Crane", ImagePath = "saruscrane.jpg" });
            //_mybirds.Add(new Birds { Title = "Himalayan Monal", ImagePath = "Himalayan-Monal.jpg" });
            //_mybirds.Add(new Birds { Title = "Indian Peafowl", ImagePath = "Indian-Peafowl.jpg" });
            //_mybirds.Add(new Birds { Title = "Mrs. Gould’s Sunbird", ImagePath = "Mrs.-Gould’s-Sunbird.jpg" });
            //_mybirds.Add(new Birds { Title = "Oriental Dwarf Kingfisher", ImagePath = "Oriental-Dwarf-Kingfisher.jpg" });
            //_mybirds.Add(new Birds {Title = "Red Headed Trogon", ImagePath = "Red-Headed-Trogon.jpg"});
        }


        public ObservableCollection<Birds> MyBirds
        {
            get
            {
                return _mybirds;
            }
            set
            {
                if (_mybirds != value)
                {
                    _mybirds = value;
                    OnPropertyChanged(nameof(_mybirds));
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}

