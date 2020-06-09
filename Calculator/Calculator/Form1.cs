using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Калькулятор : Form
    {
        public Калькулятор()
        {
            InitializeComponent();
            init();
            updateLayout();
            updateButtonsPosition();
        }

        string action = null;
        double double1 = 0;
        bool isReadyToNextValue = false;

        void init()
        {
            double1 = 0;
            action = "";
            DisplayedValue.Text = "0";
            isReadyToNextValue = false;
        }

        private void onButton(object sender, EventArgs e)
        {
            //bool isButton = sender is Button;
            Button button = sender as Button;
            string value = button.Text;
            onChar(value[0]);
        }

        private void onKeyPress(object sender, KeyPressEventArgs e)
        {
            onChar(e.KeyChar);
        }

        void button1_LostFocus(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Lost focus");
        }

        void button1_GotFocus(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Got focus");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ///MessageBox.Show(e.KeyChar.ToString());
            //e.Handled = true;
            //if (e.KeyChar == '5')
            //    e.Handled = true;
        }

        const int MIN_WIDTH_FOR_HISTORY = 560;
        const int MIN_HISTORY_WIDTH = 250;
        const int MAX_HISTORY_WIDTH = 325;
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            /*
            if (this.Width > 560)
            {
                panelHistory.Visible = true;
            }
            else
            {
                panelHistory.Visible = false;
            }
            */
            updateLayout();
        }

        void updateLayout()
        {
            History.Visible = (Width > MIN_WIDTH_FOR_HISTORY);

            //todo update history width
            //panelHistory.Width = todo;
        }

        private void panelButtons_SizeChanged(object sender, EventArgs e)
        {
            updateButtonsPosition();
        }

        void updateButtonsPosition()
        {
            int itemHeight = panel3.Height / 6;
            int itemWidth = panel3.Width / 4;

            foreach (var child in panel3.Controls)
            {
                Button btn = child as Button;
                if (btn != null)
                {
                    btn.Width = itemWidth;
                    btn.Height = itemHeight;
                }
            }
            btnEqual.Height = itemHeight * 3;

            //button1.Width = itemWidth;
            //button1.Height = itemHeight;
            button1.Location = new Point(0, 3 * itemHeight);
            button2.Location = new Point(itemWidth, 3 * itemHeight);
            button3.Location = new Point(2 * itemWidth, 3 * itemHeight);

            button4.Location = new Point(0, 2 * itemHeight);
            button5.Location = new Point(itemWidth, 2 * itemHeight);
            btn6.Location = new Point(2 * itemWidth, 2 * itemHeight);

            button7.Location = new Point(0, itemHeight);
            button8.Location = new Point(itemWidth,  itemHeight);
            button9.Location = new Point(2 * itemWidth,  itemHeight);

            button13.Location = new Point(0, 0);
            buttonDivide.Location = new Point(itemWidth, 0);
            bt.Location = new Point(2 * itemWidth, 0);

            button11.Location = new Point(3 * itemWidth, 0);
            buttonplase.Location = new Point(3 * itemWidth, itemHeight);
            btnEqual.Location = new Point(3 * itemWidth, 2 * itemHeight);
            //?
            buttonDot.Location = new Point(4 * itemWidth, 2 * itemWidth);
            buttonDel.Location = new Point(5 * itemWidth, 0 );
            buttonPlusMinus.Location = new Point(4 * itemWidth, 0 );
        }
        void OnEnter()
        {
            MessageBox.Show("нажат энтер. обработай меня");
        }
        void onChar(char value)
        {
            //MessageBox.Show(value.ToString());
            switch (value)
            {
                case '\r':
                    OnEnter();
                    break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '.':
                    onNumber(value);
                    break;
                case '+':
                case '-':
                case '/':
                case '*':
                    onAction(value);
                    break;
                case '=':
                    onEqual();
                    break;
            }
        }

        void onEqual()
        {

            double double2 = Convert.ToDouble(DisplayedValue.Text);
            switch (action)
            {
                case "+":
                    double1 = double1 + double2;
                    break;
                case "-":
                    double1 = double1 - double2;
                    break;
                case "*":
                    double1 = double1 * double2;
                    break;
                case "/":
                    double1 = double1 / double2;
                    break;
            }
            DisplayedValue.Text = double1.ToString();
            isReadyToNextValue = true;

        }

        void onAction(char value)
        {
            action = value.ToString();
            isReadyToNextValue = true;
            double1 = Convert.ToDouble(DisplayedValue.Text);
        }

        void onNumber(char value)
        {
            if (DisplayedValue.Text.Contains('.'))
            {
                if (DisplayedValue.Text.Contains('0'))
                {
                    DisplayedValue.Text.Replace('0','.');
                }
            }
            if (isReadyToNextValue)
            {
                DisplayedValue.Text = value.ToString();
            }
            else
            {
                if (value == '.')
                {
                    if (!DisplayedValue.Text.Contains('.'))
                        DisplayedValue.Text += value;
                }
                else if (DisplayedValue.Text == "0")
                {
                    DisplayedValue.Text = value.ToString();
                }
                else
                {
                    DisplayedValue.Text += value;
                }
            }
            isReadyToNextValue = false;
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (DisplayedValue.Text == "0")
            {
                return;
            }

            if (DisplayedValue.Text.StartsWith("-"))
            {
                DisplayedValue.Text = DisplayedValue.Text.Remove(0, 1);
            }
            else
            {
                DisplayedValue.Text = "-" + DisplayedValue.Text;
            }
        }

        private void onButtonClear(object sender, EventArgs e)
        {

            init();


        }

        private void onButtonDel(object sender, EventArgs e)
        {
            int length = DisplayedValue.Text.Length;

            if (length == 1)
            {
                DisplayedValue.Text = "0";
            }
            else
            {
                DisplayedValue.Text = DisplayedValue.Text.Remove(length - 1);
            }

        }
    }
}
