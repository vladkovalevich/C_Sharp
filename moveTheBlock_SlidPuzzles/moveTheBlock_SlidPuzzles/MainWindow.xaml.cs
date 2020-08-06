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
using System.IO;

namespace moveTheBlock_SlidPuzzles
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            //string writePath = @"C:\Users\vladKo\Documents\GitHub\C_Sharp\moveTheBlock_SlidPuzzles";

            //string text = score_btn.Text;
            //using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            //{
            //     sw.WriteLine(text);
            //}

        }
        void arrangeBlocks()
        {
            
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            arrangeBlocks();
            Init();
        }

    }
}
