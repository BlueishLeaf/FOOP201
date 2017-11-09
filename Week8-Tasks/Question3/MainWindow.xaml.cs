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

namespace Week8pt3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            int numberGrade = int.Parse(numTxt.Text);
            char letterGrade;
            if (numberGrade<40)
            {
                letterGrade = 'F';
            }
            else if (numberGrade>=40 && numberGrade<70)
            {
                letterGrade = 'C';
            }
            else if (numberGrade >= 70 && numberGrade < 90)
            {
                letterGrade = 'B';
            }
            else if (numberGrade >= 90 && numberGrade <= 100)
            {
                letterGrade = 'A';
            }
            else
            {
                letterGrade = 'X';
            }
            letterBox.Text = letterGrade.ToString();
        }
    }
}
