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
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;
using System.Windows.Threading;
namespace _15
{
    using System.Windows.Threading;
    public partial class MainWindow : Window
    {
        DateTime _StartTime;
        //const string pathBest = @"C:\VLAD";
        const string file = @"text.txt";

        int[,] _Data = new int[4, 4];
        
        public MainWindow()
        {
            load();
            InitializeComponent();
            //checkFoгешопренолдюьи
            init();
            getNeighborPieces();
            timer();
            
        }
     
       
        void timer()
        {
            DispatcherTimer _Timer;
            _Timer = new DispatcherTimer();
            _Timer.Interval = new TimeSpan(0, 0, 1);
            _Timer.Tick += _Timer_Tick;
            _Timer.Start();
        }

        void _Timer_Tick(object sender, EventArgs e)
        {
            _Time.Text = ((DateTime.Now - _StartTime)).ToString();
        }
       
            
        
        /*
        void checkFolder()
        {
            //если директории нет, то ее создать
            if (!Directory.Exists(pathBest))
            {
                Directory.CreateDirectory(pathBest);
                Debug.WriteLine("todo create directory");
            }
        }*/

        void init()
        {
            _StartTime = DateTime.Now;
            initArray();
            shuffle();
            updateView();
        }

        void clickField(int x, int y)
        {

            //hello
            //check left, top, right, bottom cells. if 0 then switch values
            int valueClicked = _Data[x, y];
            if (x > 0 && _Data[x - 1, y] == 0) // left
            {
                _Data[x - 1, y] = valueClicked;
                _Data[x, y] = 0;
            }
            else if (y > 0 && _Data[x, y - 1] == 0) // top
            {
                _Data[x, y - 1] = valueClicked;
                _Data[x, y] = 0;
            }
            else if (x < 3 && _Data[x + 1, y] == 0) // right
            {
                _Data[x + 1, y] = valueClicked;
                _Data[x, y] = 0;
            }
            else if (y < 3 && _Data[x, y + 1] == 0) // bottom
            {
                _Data[x, y + 1] = valueClicked;
                _Data[x, y] = 0;
            }
            updateView();
        }

        bool isCompleted()
        {
            for (int i = 0; i < 15; i++)
            {
                int x = i % 4;
                int y = i / 4;
                if (_Data[x, y] != i + 1)
                    return false;
            }
            return true;
        }

        void clickAnyField()
        {
            int rand = _Rand.Next(16);
            int x = rand % 4;
            int y = rand / 4;
            clickField(x, y);
        }

        List<Point> getNeighborPieces()
        {

            List<Point> res = new List<Point>();
            int X = 0;
            int Y = 0;
           
            //1. find X and Y coorditetes of empty cell
            for (int i = 0; i < 16; i++)
            {
                int x = i % 4;
                int y = i / 4;
                System.Diagnostics.Debug.WriteLine("Cell x = " + x + "; y = " + y + "; res = " + _Data[x, y]);

                //при каких условиях мы можем считать что текущая пара x и у соотвествует дырке. если да, то пишем x и e в X и Y и заканчиваем поиск
                if (_Data[x, y] == 0)
                {
                    X = x;
                    Y = y;
                }
            }

            //2. 
            Point top = new Point(X, Y-1);
            if (top.Y >= 0)
            {
                res.Add(top);
            }
           

            Point left = new Point(X-1, Y);
            if (left.X >= 0)
            {
                res.Add(left);
            }

            Point right = new Point(X+1, Y);
            if (right.X < 4)
            {
                res.Add(right);
            }

            Point below = new Point(X, Y+1);
            if (below.Y <= 3)
            {
                res.Add(below);
            }

            return res;
        }

        void effectiveClickRandomField()
        {
            List<Point> pieces = getNeighborPieces();
            int piecesLength = pieces.Count; 
            int rand = _Rand.Next(piecesLength);
            clickField((int)pieces[rand].X, (int)pieces[rand].Y);
        }

        Random _Rand = new Random(DateTime.Now.Millisecond);
        DateTime _TimestampStartGame = DateTime.MinValue;
        int _Diff = 3;
        void shuffle()
        {
            for (int i = 0; i < _Diff; i++) 
            {
                effectiveClickRandomField();
            }
            _TimestampStartGame = DateTime.Now;
            try
            {
                RegistryKey key;
                key = Registry.CurrentUser.CreateSubKey("15");
                object res = key.GetValue("BestHard");
                if (res != null)
                {
                    int bestHard = (int)res;
                    TextBlock1000.Text = "The best (" + bestHard + ")";
                }
                else
                {
                    TextBlock1000.Text = "NO RECORDS";
                }

                
                res = key.GetValue("BestMeduim");
                if (res != null)
                {
                    int bestMedium = (int)res;
                    TextBlock100.Text = "The best (" + bestMedium + ")";
                }
                else
                {
                    TextBlock100.Text = "NO RECORDS";
                }


                res = key.GetValue("BestSimple");
                if (res != null)
                {
                    int bestSimple = (int)res;
                    TextBlock10.Text = "The best (" + bestSimple + ")";
                }
                else
                {
                    TextBlock10.Text = "NO RECORDS";
                }

                key.Close();
            }
            catch
            {
                
            }
        }

        void initArray()
        {
            for (int i = 0; i < 15; i++)
            {
                int x = i % 4;
                int y = i / 4;
                _Data[x, y] = i + 1;
            }
            _Data[3, 3] = 0;
        }

        void updateView()
        {
            for (var i = 0; i < 16; i++)
            {
                Button btn = _Root.Children[i] as Button;
                int x = i % 4;
                int y = i /4;
                btn.Content = _Data[x, y];
                btn.Visibility = _Data[x, y] == 0 ? Visibility.Collapsed : Visibility.Visible;
            }
        }

        int _BestSimple = 0;
        int _BestHard = 0;
        int _BestMedium = 0;

        void save()
        {
            //todo save to file
        }

        void load()
        {
            //todo read from file if it exisis
            ///_BestSimple = ....
            ///_BestHard = ....
            ///_BestMedium = ....
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (isCompleted())
                return;
            Button btn = sender as Button;
            int x = Grid.GetColumn(btn);
            int y = Grid.GetRow(btn);
            clickField(x, y);
            if (isCompleted())
            {
                //RegistryKey key;
                //key = Registry.CurrentUser.CreateSubKey("15");

                TimeSpan difference =  DateTime.Now - _TimestampStartGame;
                if (NameBlock100.IsChecked == true)
                {
                    if (difference.TotalSeconds < _BestMedium || _BestMedium == 0)
                    {
                        MessageBox.Show("Congrats to you!" + (int)difference.TotalSeconds);
                        _BestMedium = (int)difference.TotalSeconds;
                        save();
                        _TextBlock100(_BestMedium);
                    }
                    else
                    {
                        MessageBox.Show("Cool!" + (int)difference.TotalSeconds);
                    }
                }
                else if (NameBlock1000.IsChecked == true)
                {
                    /*
                    double Best1000 = difference.TotalSeconds;
                    if (difference.TotalSeconds > Best1000)
                    {
                        MessageBox.Show("Congrats to you!" + (int)difference.TotalSeconds);
                    }
                    else
                    {
                        MessageBox.Show("Cool!" + (int)difference.TotalSeconds);
                    }
                    key.SetValue("BestHard", (int)Best1000);
                    _TextBlock1000((int)Best1000);
                     * */
                }
                else if (NameBlock10.IsChecked == true)
                {
                    /*
                   double Best10  = difference.TotalSeconds;
                   if (difference.TotalSeconds > Best10)
                   {
                       MessageBox.Show("Congrats to you!" + (int)difference.TotalSeconds);
                   }
                   else
                   {
                       MessageBox.Show("Cool!" + (int)difference.TotalSeconds);
                   }
                   key.SetValue("BestSimple", (int)Best10);
                   _TextBlock10((int)Best10);
                     * */
                }
          
                //key.Close();
            }
        }

        private void _RestartBtn_Click_1(object sender, RoutedEventArgs e)
        {
            init();
        }

        private void RadioButton_Checked_10(object sender, RoutedEventArgs e)
        {
            _Diff = 3; 
        }
        private void RadioButton_Checked_100(object sender, RoutedEventArgs e)
        {
            _Diff = 10;
        }
        private void RadioButton_Checked_1000(object sender, RoutedEventArgs e)
        {
            _Diff = 20;
        }
        void _TextBlock1000(int difference)
        {
            TextBlock1000.Text = "The best (" + difference + ")";
        }
        void _TextBlock10(int difference)
        {
            TextBlock10.Text = "The best (" + difference + ")";
        }
        void _TextBlock100(int difference)
        {
            TextBlock100.Text = "The best (" + difference + ")";
        }
    }
}