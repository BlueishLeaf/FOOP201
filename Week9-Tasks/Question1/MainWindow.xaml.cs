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

namespace Question1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int scoreCount=0;
        int scoreTotal=0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            scoreCount = 0;
            scoreTotal = 0;
            scoreTotalBlock.Text = null;
            scoreCountBlock.Text = null;
            scoreAverageBlock.Text = null;
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            scoreTotal += int.Parse(scoreBox.Text);
            scoreCount++;
            scoreTotalBlock.Text = scoreTotal.ToString();
            scoreCountBlock.Text = scoreCount.ToString();
            scoreAverageBlock.Text = (scoreTotal / scoreCount).ToString();
        }

        private void Button_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
