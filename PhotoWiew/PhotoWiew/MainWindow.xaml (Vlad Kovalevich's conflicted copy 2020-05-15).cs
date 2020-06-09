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
            Uptade();
            //TODO просмотреть папку с приложением, найти там все картинки, и для каждой создать Image элемент и добавить в _ImagesConteiner
        }

        void Uptade()
        {
            
        }
        void _FileName() 
        { 
            //todo
        }
        private void Open_click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".png";
            dlg.Filter = "All Photo(*.*)|*.jpeg;*.png;*.gif;*.jpg|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            //TODO добавить фильтр "все картнки" в 0 позицию
            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                string filename = dlg.FileName;
                ImageSource imageSource = new BitmapImage(new Uri(filename));
                CenterImage.Source = imageSource;
            }

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            //todo скорпировать выбранный файл СПАРВА в папку с приложением
            //todo добавить в _ImagesConteiner еще один Image
        }
    }
} 

