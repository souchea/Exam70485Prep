using System;
using System.Collections.Generic;
using System.Text;
using Windows.Media.Capture;

namespace Exam70485Prep.ViewModel.chapter2
{
    public class CameraViewModel : BaseViewModel
    {
        private MediaCapture _webcamCapture;

        public MediaCapture WebcamCapture
        {
            get { return _webcamCapture; }
            set
            {
                _webcamCapture = value;
                NotifyPropertyChanged("WebcamCapture");
            }
        }

    }
}
