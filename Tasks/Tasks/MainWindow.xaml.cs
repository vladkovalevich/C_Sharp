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

namespace Tasks
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 6 8
           //https://acmp.ru/index.asp?main=task&id_task=33
            string[] A = Input.Text.Split(' ');
            int Larry = 10;
            int Harry = 10;
            Larry = Larry - Convert.ToInt32(A[0]);
            Harry = Harry - Convert.ToInt32(A[1]);
            string Resault = Convert.ToString(Larry) + " " + Convert.ToString(Harry);
            Output.Text = Resault;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Привет
            if(Convert.ToInt32(Input.Text) >100)
               Output.Text = "Error";
            else
               Output.Text = Input.Text;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //5 1 0 1 1 0
            //https://acmp.ru/index.asp?main=task&id_task=106
            string[] A = Input.Text.Split(' ');
            int n = 0;
            for (int i = 0 ; i < Convert.ToInt32(A[0]); i++)
            {
                if (Convert.ToInt32(A[i+1]) == 1)
                {
                }
                if(Convert.ToInt32(A[i + 1]) == 0)
                {
                    Output.Text = Convert.ToString(n += 1);
                }
            }
        }
    }
}
