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


        private void onButton_ClickVlad(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(btnEqual)) 
            {
            }
            else if (sender.Equals(btnPlus)) 
            {
            }
            else if (sender.Equals(btnDivide))
            {
            }
            else if (sender.Equals(btnMulti))
            {
            }
            else if (sender.Equals(btnMinus))
            {
            }
            else if (sender.Equals(btnDel))
            {
                Console.WriteLine("Del");
            }
            /*
            else if (sender.Equals(btn0))
            {
            }
            else if (sender.Equals(btn1))
            {
            }
            else if (sender.Equals(btn2))
            {
            }
            else if (sender.Equals(btn3))
            {
            }
            else if (sender.Equals(btn4))
            {
            }
            else if (sender.Equals(btn5))
            {
            }
            else if (sender.Equals(btn6))
            {
            }
            else if (sender.Equals(btn7))
            {
            }
            else if (sender.Equals(btn8))
            {
            }
            else if (sender.Equals(btn9))
            {
            }*/
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnOperation_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnPlus":
                   //todo
                    break;
                case "btnMinus":
                    //todo
                    break;
                case "btnDivide":
                    //todo
                    break;
                case "btnMulti":
                    //todo
                    break;
            }
        }

        private void onNumericButton_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string buttonContent = btn.Content as string;
            int number = Convert.ToInt32(buttonContent);
            // todo: use number
        }
    }
}
