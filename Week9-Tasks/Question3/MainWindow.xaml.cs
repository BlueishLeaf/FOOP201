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

namespace Question3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double operand1;
        double operand2;
        char op;
        double result;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            operand1 = double.Parse(operand1Box.Text);
            operand2 = double.Parse(operand2Box.Text);
            op = operatorBox.Text[0];
            result = CalcResult(operand1, operand2, op);
            resultBlock.Text = result.ToString();
        }

        private double CalcResult(double x, double y, char op)
        {
            double result = 0;
            if (op=='+')
            {
                result = x + y;
            }
            else if (op == '-')
            {
                result = x - y;
            }
            else if (op == '*')
            {
                result = x * y;
            }
            else if (op == '/')
            {
                result = x / y;
            }
            else if (op == '%')
            {
                result = x % y;
            }

            return result;
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
