using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XamarinCodeLibrary.Annotations;
using XamarinCodeLibrary.Models;

namespace XamarinCodeLibrary.ViewModels.EssentialViewModels
{
    public class CommonServiceMainPageViewModel : INotifyPropertyChanged
    {
        private List<CommonServiceModel> _services;
        public List<CommonServiceModel> Services { get; set; }


        public CommonServiceMainPageViewModel()
        {
            Services = new List<CommonServiceModel>
            {
                new CommonServiceModel{ServiceName = "Accelerometer"},
                new CommonServiceModel{ServiceName = "App Information"},
                new CommonServiceModel{ServiceName = "App Theme"},
                new CommonServiceModel{ServiceName = "Barometer"},
                new CommonServiceModel{ServiceName = "Battery"},
                new CommonServiceModel{ServiceName = "Clipboard"},
                new CommonServiceModel{ServiceName = "Color Converters"},
                new CommonServiceModel{ServiceName = "Compass"},
                new CommonServiceModel{ServiceName = "Connectivity"},
                new CommonServiceModel{ServiceName = "Detect Shake"},
                new CommonServiceModel{ServiceName = "Device Display Information"},
                new CommonServiceModel{ServiceName = "Device Information"},
                new CommonServiceModel{ServiceName = "Email"},
                new CommonServiceModel{ServiceName = "File System Helpers"},
                new CommonServiceModel{ServiceName = "FlashLights"},
                new CommonServiceModel{ServiceName = "Geocoding"},
                new CommonServiceModel{ServiceName = "Geolocation"},
                new CommonServiceModel{ServiceName = "Gyroscope"},
                new CommonServiceModel{ServiceName = "Launcher"},
                new CommonServiceModel{ServiceName = "Magnetometer"},
                new CommonServiceModel{ServiceName = "Main Thread"},
                new CommonServiceModel{ServiceName = "Maps"},
                new CommonServiceModel{ServiceName = "Open Browser"},
                new CommonServiceModel{ServiceName = "Orientation Sensor"},
                //new CommonServiceModel{ServiceName = "Permissions"},
                new CommonServiceModel{ServiceName = "Phone Dialer"},
                //new CommonServiceModel{ServiceName = "Platform Extensions"}, block
                new CommonServiceModel{ServiceName = "Shared Preferences"},
                new CommonServiceModel{ServiceName = "Secure Storage"},// bir sonraki gün...
                new CommonServiceModel{ServiceName = "Share"},
                new CommonServiceModel{ServiceName = "SMS"},
                new CommonServiceModel{ServiceName = "Text-to-Speech"},
                new CommonServiceModel{ServiceName = "Unit Converters"},
                new CommonServiceModel{ServiceName = "Version Tracking"},
                new CommonServiceModel{ServiceName = "Vibrate"},

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
