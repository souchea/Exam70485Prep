using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Exam70485Prep.Model;
using Exam70485Prep.View;
using Exam70485Prep.View.Chapter1;
using Exam70485Prep.View.Chapter2;
using Exam70485Prep.View.Chapter3;
using Exam70485Prep.View.Chapter4;
using Exam70485Prep.View.Chapter5;
using Exam70485Prep.View.Chapter6;

namespace Exam70485Prep.ViewModel
{
    public class MainPageViewModel : BaseViewModel
    {
        private ObservableCollection<Item> _chapter1Items;

        public ObservableCollection<Item> Chapter1Items
        {
            get { return _chapter1Items; }
            set
            {
                _chapter1Items = value;
                NotifyPropertyChanged("Chapter1Items");
            }
        }

        private ObservableCollection<Item> _chapter2Items;

        public ObservableCollection<Item> Chapter2Items
        {
            get { return _chapter2Items; }
            set
            {
                _chapter2Items = value;
                NotifyPropertyChanged("Chapter2Items");
            }
        }

        private ObservableCollection<Item> _chapter3Items;

        public ObservableCollection<Item> Chapter3Items
        {
            get { return _chapter3Items; }
            set
            {
                _chapter3Items = value;
                NotifyPropertyChanged("Chapter3Items");
            }
        }

        private ObservableCollection<Item> _chapter4Items;

        public ObservableCollection<Item> Chapter4Items
        {
            get { return _chapter4Items; }
            set
            {
                _chapter4Items = value;
                NotifyPropertyChanged("Chapter4Items");
            }
        }

        private ObservableCollection<Item> _chapter5Items;

        public ObservableCollection<Item> Chapter5Items
        {
            get { return _chapter5Items; }
            set
            {
                _chapter5Items = value;
                NotifyPropertyChanged("Chapter5Items");
            }
        }

        private ObservableCollection<Item> _chapter6Items;

        public ObservableCollection<Item> Chapter6Items
        {
            get { return _chapter6Items; }
            set
            {
                _chapter6Items = value;
                NotifyPropertyChanged("Chapter6Items");
            }
        }

        public MainPageViewModel()
        {
            Chapter1Items = new ObservableCollection<Item>(new List<Item>
            {
                new Item
                {
                    Name = "BackgroundTaskPage",
                    Page = typeof(BackgroundTaskPage)
                },
                new Item 
                {
                    Name = "WinMDPage",
                    Page = typeof(WinMDPage)
                }
            });

            Chapter2Items = new ObservableCollection<Item>(new List<Item>
            {
                new Item
                {
                    Name = "Camera",
                    Page = typeof(CameraPage)
                },
                new Item 
                {
                    Name = "Accelerometer",
                    Page = typeof(AccelerometerPage)
                },
                new Item 
                {
                    Name = "Gyrometer",
                    Page = typeof(GyrometerPage)
                },
                new Item 
                {
                    Name = "Compass",
                    Page = typeof(CompassPage)
                },
                new Item 
                {
                    Name = "Inclinometer",
                    Page = typeof(InclinometerPage)
                },
                new Item 
                {
                    Name = "Location",
                    Page = typeof(LocationPage)
                },
                new Item 
                {
                    Name = "Device",
                    Page = typeof(DevicePage)
                }
            });

            Chapter3Items = new ObservableCollection<Item>(new List<Item>
            {
                new Item
                {
                    Name = "Printing",
                    Page = typeof(PrintingPage)
                },
                new Item
                {
                    Name = "Play To",
                    Page = typeof(PlayToPage)
                },
                new Item 
                {
                    Name = "Notification (WNS)",
                    Page = typeof(NotificationPage)
                }
            });

            Chapter4Items = new ObservableCollection<Item>(new List<Item>
            {
                new Item
                {
                    Name = "Responsiveness",
                    Page = typeof(ResponsivePage)
                },
                new Item
                {
                    Name = "Animations & Transitions",
                    Page = typeof(AnimationsPage)
                },
                new Item 
                {
                    Name = "Custom controls",
                    Page = typeof(CustomPage)
                },
                new Item 
                {
                    Name = "Globalization",
                    Page = typeof(GlobalizationPage)
                }
            });

            Chapter5Items = new ObservableCollection<Item>(new List<Item>
            {
                new Item
                {
                    Name = "Data caching",
                    Page = typeof(DataCachingPage)
                },
                new Item
                {
                    Name = "Retrieve files",
                    Page = typeof(FilesPage)
                },
                new Item 
                {
                    Name = "App data",
                    Page = typeof(AppDataPage)
                }
            });

            Chapter6Items = new ObservableCollection<Item>(new List<Item>
            {
                new Item
                {
                    Name = "Trial",
                    Page = typeof(TrialPage)
                },
                new Item
                {
                    Name = "Error handling",
                    Page = typeof(ErrorPage)
                },
                new Item 
                {
                    Name = "Test strategy",
                    Page = typeof(TestPage)
                },
                new Item 
                {
                    Name = "Diagnostics",
                    Page = typeof(DiagnosticsPage)
                }
            });
        } 
    }
}
