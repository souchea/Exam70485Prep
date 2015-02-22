using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Exam70485Prep.View;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Exam70485Prep
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Chapter1));
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Chapter6));
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Chapter2));
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Chapter5));
        }

        private void button_Copy4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Chapter3));
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Chapter4));
        }
    }
}
