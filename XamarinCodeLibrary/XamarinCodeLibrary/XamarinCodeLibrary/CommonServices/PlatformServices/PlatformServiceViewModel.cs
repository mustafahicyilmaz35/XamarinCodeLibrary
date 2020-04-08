using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XamarinCodeLibrary.Annotations;

namespace XamarinCodeLibrary.CommonServices.PlatformServices
{
    public class PlatformServiceViewModel : INotifyPropertyChanged
    {

        private List<PlatformServiceModel> _services;

        public List<PlatformServiceModel> Services
        {
            get => _services;
            set
            {
                _services = value;
                OnPropertyChanged(nameof(Services));
            }
        }

        public PlatformServiceViewModel()
        {
            Services = new List<PlatformServiceModel>
            {
                new PlatformServiceModel{Name = "WhatsApp"}
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
