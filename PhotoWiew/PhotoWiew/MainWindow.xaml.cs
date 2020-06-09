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
        //todo сделать так, чтобы гифка проигрывалась

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

            string filename = Path.GetFileName(_FileFullPath);

            string URL = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + '\\' + filename;
            try
            {
                File.Copy(_FileFullPath, URL, true);
                addFileToImagesContainer(_FileFullPath);
            }
            catch
            {
                return;
            }

        }

        bool IsPicture(string file)
        {
            /*
            if (file.EndsWith(".png"))
                return true;
            else if(file.EndsWith(".jpeg"))
                return true;
            else if (file.EndsWith(".gif"))
                return true;
            else if (file.EndsWith(".jpg"))
                return true;
            //*.jpeg;*.png;*.gif;*.jpg
            return false;
            */
            return file.EndsWith(".png") ||
                file.EndsWith(".gif") ||
                file.EndsWith(".jpg") ||
                file.EndsWith(".jpeg");
        }

        void addFileToImagesContainer(string fileFullPath)
        {
            Border borderOuter = new Border()
            {
                Width = 200,
                Height = 200,
                CornerRadius = new CornerRadius(50),
                BorderBrush = new SolidColorBrush(Colors.Blue),
                BorderThickness = new Thickness(5)
            };
            Grid grid = new Grid();
            Border borderInner = new Border()
            {
                CornerRadius = new CornerRadius(50),
                Background = new SolidColorBrush(Colors.Blue),
                Margin = new Thickness(-1)
            };
            Image img = new Image()
            {
                Stretch = Stretch.Fill,
                Source = new BitmapImage(new Uri(fileFullPath))
            };

            grid.Children.Add(borderInner);
            grid.Children.Add(img);
            borderOuter.Child = grid;
            _ImagesContainer.Children.Add(borderOuter);
            grid.OpacityMask = new VisualBrush(borderInner);
        }
        //todo: починить скругление 
        void InitView()
        {
            string URL = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string[] allFiles = Directory.GetFiles(URL);
            foreach (string file in allFiles)
            {
                if (IsPicture(file))
                {
                    addFileToImagesContainer(file);
                }
            }
            System.Diagnostics.Debug.WriteLine(URL);

            /*
            //TODO 
            1  просмотреть папку с приложением, т.е. получить список файлов в папке
            2. найти там все картинки,
            3. и для каждой создать Image элемент и добавить в _ImagesConteiner
            */
        }
    }
}
        


 

