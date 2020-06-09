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
//            string test = "\"\"";
//            string test1 = @"""";

            if (_FileFullPath == null)
                return;
            /*
            string[] resault = _FileFullPath.Split(new Char[] { '\\' });
            string filename = "";
            foreach (string resault_FileFullPath in resault)
            {
                filename = resault_FileFullPath;
            }
            */
            //string URL = @"e:\test" + @"\" + (Guid.NewGuid().ToString()) + "file.png";


            string filename = Path.GetFileName(_FileFullPath);

            string URL = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + '\\' + filename;
            
            File.Copy(_FileFullPath, URL, true);
            //todo добавить в _ImagesConteiner еще один
            ImageSource imageSource = new BitmapImage(new Uri(_FileFullPath));
            Image image1 = new Image();
            image1.Source = imageSource;
            _ImagesContainer.Children.Add(image1);



        }


        void InitView()
        {
            string URL = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            
            /*
            //TODO 
            1 просмотреть папку с приложением, т.е. получить список файлов в папке
            2. найти там все картинки, 
            3. и для каждой создать Image элемент и добавить в _ImagesConteiner
            */
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

 

