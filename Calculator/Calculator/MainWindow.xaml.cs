﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.NewSize.Width < 500)
            {
                History.Visibility = Visibility.Collapsed;
            }
            else
            {
                History.Visibility = Visibility.Visible;
            }

            //History.Visibility = (e.NewSize.Width < 500) ? Visibility.Collapsed : Visibility.Visible;
        }

        private void onButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
