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
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {

        double num1, num2;
        bool num2Flg = false;
        String operand;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button wk = (Button)sender;
            text.Text += wk.Content.ToString();
        }

        private void Operand_Click(object sender, RoutedEventArgs e)
        {
            Button wk = (Button)sender;

            num1 = double.Parse(text.Text); // num1に値を保存
            text.Text = ""; // 表示部の初期化
            operand = wk.Content.ToString(); // 演算記号の保存
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            text.Text = ""; // 表示部の初期化
            num2Flg = false; // フラグの初期化
        }

        private void Root_Click(object sender, RoutedEventArgs e)
        {
            double num = double.Parse(text.Text);
            if(num >= 0)
            {
                text.Text = Math.Sqrt(num).ToString();
            }
            else
            {
                text.Text = "ERR!";
            }
        }

        private void PosiNega_Click(object sender, RoutedEventArgs e)
        {
            double num = double.Parse(text.Text);
            text.Text = (num * -1).ToString();
        }

        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            num2 = double.Parse(text.Text); // num2に値を保存
            if(operand.Equals("+"))
            {
                text.Text = (num1 + num2).ToString();
            }
            else if (operand.Equals("-"))
            {
                text.Text = (num1 - num2).ToString();
            }
            else if (operand.Equals("×"))
            {
                text.Text = (num1 * num2).ToString();
            }
            else if (operand.Equals("÷"))
            {
                text.Text = (num1 / num2).ToString();
            }
            else
            {
                text.Text = "ERROR!";
            }
        }

    }
}
