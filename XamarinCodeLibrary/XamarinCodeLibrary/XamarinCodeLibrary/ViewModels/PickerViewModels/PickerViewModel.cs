using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XamarinCodeLibrary.Annotations;

namespace XamarinCodeLibrary.ViewModels.PickerViewModels
{
    public class PickerViewModel : INotifyPropertyChanged
    {
        public List<PickerPerson> People { get; set; }
        public PickerViewModel()
        {
            People = new List<PickerPerson>
            {
                new PickerPerson{Name = "Hasan"},
                new PickerPerson{Name = "Mustafa"},
                new PickerPerson{Name = "Sıla"},
                new PickerPerson{Name = "Ebrar"},
            };
        }


        private PickerPerson _selectedName;

        public PickerPerson SelectedName
        {
            get => _selectedName;
            set
            {
                if (_selectedName != value)
                {
                    _selectedName = value;
                    MySelectedName = "Merhaba " + _selectedName.Name;
                }
            }
        }

        private string _mySelectedName;

        public string MySelectedName
        {
            get => _mySelectedName;
            set
            {
                if (_mySelectedName != value)
                {
                    _mySelectedName = value;
                    OnPropertyChanged();
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
