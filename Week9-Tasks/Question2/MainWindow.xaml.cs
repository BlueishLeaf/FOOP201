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

namespace Question2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num;
        int factorial;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void factorialButton_Click(object sender, RoutedEventArgs e)
        {
            num = int.Parse(numBox.Text);
            factorial = getFactorial(num);
            factorialBlock.Text = factorial.ToString();
        }

        private int getFactorial(int num)
        {
            int newFac = num;
            for (int i=1;i<num;i++)
            {
                newFac *= (num-i);
            }
            return newFac;

        }
    }
}
