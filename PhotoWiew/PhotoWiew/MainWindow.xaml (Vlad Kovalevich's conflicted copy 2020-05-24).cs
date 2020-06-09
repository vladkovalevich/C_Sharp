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
using System.Windows.Diagnostics;
using System.IO;

namespace PhotoWiew
{
    public partial class MainWindow : Window
    {
        string _FileFullPath = null;
        public MainWindow()
        {
            InitializeComponent();
            InitView();
        }

        private void Open_click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".png";
            dlg.Filter = "All Photo(*.*)|*.jpeg;*.png;*.gif;*.jpg|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                _FileFullPath = dlg.FileName;
                ImageSource imageSource = new BitmapImage(new Uri(_FileFullPath));
                CenterImage.Source = imageSource;
            }

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (_FileFullPath == null)
                return;
            //todo скорпировать выбранный файл СПАРВА в папку с приложением
            //todo: получить путь где сейчас работает exe файл

            //string URL = @"e:\test" + @"\" + (Guid.NewGuid().ToString()) + "file.png";

            string filename = ""; //todo: get real filename (hint class Path)

            string URL = @"C:Users\VLAD\Dropbox\Projects\PhotoWiew\PhotoWiew\bin\x86\Debug\" + filename;

            File.Copy(_FileFullPath, URL, true);

            //todo добавить в _ImagesConteiner еще один 
         
        }

        void InitView()
        {
            //TODO просмотреть папку с приложением, найти там все картинки, и для каждой создать Image элемент и добавить в _ImagesConteiner
        }
    }
    /*
    class FileName
    {
        string fileName;
        public string Name
        {
            set
            {
                fileName = value;
                if (NameChange != null)
                    NameChange.Invoke();
            }
            get
            {
                return fileName;
            }
        }
            public event Action NameChange = null;
    }*/
}

 

