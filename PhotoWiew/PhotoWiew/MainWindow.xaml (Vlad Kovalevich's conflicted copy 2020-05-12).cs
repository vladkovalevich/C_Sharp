using System;
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
using System.Windows.Diagnostics;
namespace PhotoWiew
{ 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        { 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            Nullable<bool> result = dlg.ShowDialog();
            string filename = dlg.FileName;
            if (result == true)
            {
                ImageSource imageSource = new BitmapImage(new Uri(filename));
                CenterImage.Source = imageSource;
                Image1.Source = imageSource;
                TextSourse.Text = filename;
            }
        }

        private void Open_click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = "All Photo";
            dlg.Filter = "All Photo|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            Nullable<bool> result = dlg.ShowDialog();
            string filename = dlg.FileName;
            if (result == true)
            {
                ImageSource imageSource = new BitmapImage(new Uri(filename));
                CenterImage.Source = imageSource;
                TextSourse.Text = filename;
            }
        }

        private void TextSourse_TextChanged(object sender, TextChangedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            Nullable<bool> result = dlg.ShowDialog();
            string filename = dlg.FileName;
            if (result == true)
            {
                ImageSource imageSource = new BitmapImage(new Uri(filename));
                CenterImage.Source = imageSource;
                TextSourse.Text = filename;
            }
        }
    }
}
