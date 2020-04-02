
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinCodeLibrary.CommonServices;
using XamarinCodeLibrary.CommonServices.EssentialServices;
using XamarinCodeLibrary.CommonServices.EssentialServices.ColorconvertesService;
using XamarinCodeLibrary.CommonServices.EssentialServices.Compass;
using XamarinCodeLibrary.Models;
using XamarinCodeLibrary.Views.UserControls.TextDemos;

namespace XamarinCodeLibrary.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CommonServiceMainPage : ContentPage
    {
        public CommonServiceMainPage()
        {
            InitializeComponent();
        }


        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;

            if (sender is ListView lv) lv.SelectedItem = null;

            switch ((e.SelectedItem as CommonServiceModel).ServiceName)
            {
                case "Accelerometer":
                    Navigation.PushAsync(new AccelerometerPage());
                    break;
                case "App Information":
                    Navigation.PushAsync(new AppInfoPage());
                    break;
                case "App Theme":
                    Navigation.PushAsync(new AppThemePage());
                    break;
                case "Barometer":
                    Navigation.PushAsync(new BarometerPage());
                    break;
                case "Battery":
                    Navigation.PushAsync(new BatteryPage());
                    break;
                case "Clipboard":
                    Navigation.PushAsync(new ClipBoardPage());
                    break;
                case "Connectivity":
                    Navigation.PushAsync(new ConnectivityPage());
                    break;
                case "Color Converters":
                    Navigation.PushAsync(new ColorconverterPage()); // us 2.3
                    break;
                case "Compass":
                    Navigation.PushAsync(new CompassPage()); // us 2.3
                    break;
                case "Detect Shake":
                    Navigation.PushAsync(new LoginPageXaml()); // us 2.3
                    break;
                case "Device Display Information":
                    Navigation.PushAsync(new DeviceDisplayInfo()); // us 2.3
                    break;
                case "Device Information":
                    Navigation.PushAsync(new DeviceInfo()); // us 2.3
                    break;
                case "Email":
                    Navigation.PushAsync(new EmailPage()); // us 2.3
                    break;
                case "File System Helpers":
                    Navigation.PushAsync(new FileSystemPage()); // us 2.4.1
                    break;
                case "FlashLights":
                    Navigation.PushAsync(new FlashLightPage()); // us 2.4.2 //block // Emulatorde catch bloğuna giriyor, gerçek device da test edilecek.
                    break;
                case "Geolocation":
                    Navigation.PushAsync(new GeoLocationPage()); // us 2.4.3
                    break;
                case "Geocoding":
                    Navigation.PushAsync(new GeoCodingEssentialPage()); // us 2.4.4
                    break;
                case "Launcher":
                    Navigation.PushAsync(new LauncherPage()); // us 2.4.5
                    break;
                case "Gyroscope":
                    Navigation.PushAsync(new GyroscopePage()); // us 2.4.6
                    break;
                case "Magnetometer":
                    Navigation.PushAsync(new MagnometerPage()); // us 2.4.7
                    break;
                case "Main Thread":
                    Navigation.PushAsync(new MainThreadPage()); // us 2.5.1
                    break;
                case "Maps":
                    Navigation.PushAsync(new MapPage()); // us 2.5.2
                    break;
                case "Open Browser":
                    Navigation.PushAsync(new OpenBrowserPage()); // us 2.5.3
                    break;
                case "Orientation Sensor":
                    Navigation.PushAsync(new OrientationSensorPage()); // us 2.5.4
                    break;
                case "Phone Dialer":
                    Navigation.PushAsync(new PhoneDialerPage()); // us 2.5.5
                    break;
                //Platform extension block us 2.5.6
                case "Shared Preferences":
                    Navigation.PushAsync(new SharedPreferencePage()); // us 2.5.6
                    break;
                case "Share":
                    Navigation.PushAsync(new SharePage()); // us 2.5.7
                    break;

            }

        }

    }
}