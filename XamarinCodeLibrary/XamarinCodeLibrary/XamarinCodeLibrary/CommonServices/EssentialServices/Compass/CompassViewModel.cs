using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinCodeLibrary.CommonServices.EssentialServices.Compass
{
    public class CompassViewModel : MvvmHelpers.BaseViewModel
    {
        public CompassViewModel()
        {
            StopCommand = new Command(Stop);
            StartCommand = new Command(Start);
        }
        string headingDisplay;
        public string HeadingDisplay
        {
            get => headingDisplay;
            set => SetProperty(ref headingDisplay, value);
        }

        double heading = 0;
        public double Heading
        {
            get => heading;
            set => SetProperty(ref heading, value);
        }

        public Command StopCommand { get; }

        void Stop()
        {
            if (!Xamarin.Essentials.Compass.IsMonitoring)
                return;

            Xamarin.Essentials.Compass.ReadingChanged -= Compass_ReadingChanged;
            Xamarin.Essentials.Compass.Stop();
        }


        public Command StartCommand { get; }

        void Start()
        {
            if (Xamarin.Essentials.Compass.IsMonitoring)
                return;

            //Xamarin.Essentials.Compass.applyLowPassFilter = true;
            Xamarin.Essentials.Compass.ReadingChanged += Compass_ReadingChanged;
            Xamarin.Essentials.Compass.Start(SensorSpeed.UI);

        }

        void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
        {
            Heading = e.Reading.HeadingMagneticNorth;
            HeadingDisplay = $"Heading: {Heading.ToString()}";
        }
    }
}

