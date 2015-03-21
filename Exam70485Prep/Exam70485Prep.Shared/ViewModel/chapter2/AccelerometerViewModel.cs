using System;
using System.Collections.Generic;
using System.Text;
using Windows.Devices.Sensors;

namespace Exam70485Prep.ViewModel.chapter2
{
    public class AccelerometerViewModel : BaseViewModel
    {
        private double _x;

        public double X
        {
            get { return _x; }
            set
            {
                _x = value;
                NotifyPropertyChanged("X");
            }
        }

        private double _y;

        public double Y
        {
            get { return _y; }
            set
            {
                _y = value;
                NotifyPropertyChanged("Y");
            }
        }

        private double _z;

        public double Z
        {
            get { return _z; }
            set
            {
                _z = value;
                NotifyPropertyChanged("Z");
            }
        }
        
        public void ReadingChanged(AccelerometerReading reading)
        {
            X = reading.AccelerationX;
            Y = reading.AccelerationY;
            Z = reading.AccelerationZ;
        }

    }
}
