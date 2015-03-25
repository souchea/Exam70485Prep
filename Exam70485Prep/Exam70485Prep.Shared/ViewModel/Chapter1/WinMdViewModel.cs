using System;
using System.Collections.Generic;
using System.Text;
namespace Exam70485Prep.ViewModel.Chapter1
{
    public class WinMdViewModel : BaseViewModel
    {
        private int _number;

        public int Number
        {
            get { return _number; }
            set
            {
                _number = value;
                NotifyPropertyChanged("Number");
            }
        }
        
        public WinMdViewModel()
        {
            var winMdClass = new Exam70485Prep_WinMD.WinMdTest();

            Number = winMdClass.TestWinMdReturn();

        }
    }
}
