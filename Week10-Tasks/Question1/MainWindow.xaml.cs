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

namespace Question4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Product[] prodArray = new Product[6];
        Product[] cartArray = new Product[6];
        Product[] filteredArray = new Product[6];
        Variation type1 = new Variation { VariationType = "Male" };
        Variation type2 = new Variation { VariationType = "Female" };


        public MainWindow()
        {
            InitializeComponent();

            Product productA = new Product { ID = 100, Name = "Road Bike", Price = 69.69, varType=type1 };
            Product productB = new Product { ID = 101, Name = "Mountain Bike", Price = 55.60,varType=type1 };
            Product productC = new Product { ID = 102, Name = "Hybrid Bike", Price = 3.50, varType = type1 };
            Product productD = new Product { ID = 103, Name = "Road Bike", Price = 69.69, varType = type2 };
            Product productE = new Product { ID = 104, Name = "Mountain Bike", Price = 55.60, varType = type2 };
            Product productF = new Product { ID = 105, Name = "Hybrid Bike", Price = 3.50, varType = type2 };
            prodArray[0] = productA;
            prodArray[1] = productB;
            prodArray[2] = productC;
            prodArray[3] = productD;
            prodArray[4] = productE;
            prodArray[5] = productF;


        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void addTaxButton_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < prodArray.Length; i++)
            {
                prodArray[i].AddTax(0.32);
                prodArray[i].Price += prodArray[i].Tax;
            }
            prodBox.ItemsSource = "";
            prodBox.ItemsSource = prodArray;
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void removeFromCartButton_Click(object sender, RoutedEventArgs e)
        {
            Product selectedProduct = cartBox.SelectedItem as Product;
            if (selectedProduct != null && prodArray.Contains(selectedProduct) == false)
            {
                prodBox.ItemsSource = "";
                prodArray[Array.IndexOf(cartArray, selectedProduct)] = selectedProduct;
                cartArray[Array.IndexOf(cartArray, selectedProduct)] = null;
                cartBox.ItemsSource = "";
                cartBox.ItemsSource = cartArray;
                prodBox.ItemsSource = prodArray;
            }
        }

        private void addToCartButton_Click(object sender, RoutedEventArgs e)
        {
            Product selectedProduct = prodBox.SelectedItem as Product;
            if (selectedProduct!=null && cartArray.Contains(selectedProduct)==false)
            {
                cartBox.ItemsSource = "";
                cartArray[Array.IndexOf(prodArray, selectedProduct)] = selectedProduct;
                prodArray[Array.IndexOf(prodArray,selectedProduct)]= null;
                prodBox.ItemsSource = "";
                prodBox.ItemsSource = prodArray;
                cartBox.ItemsSource = cartArray;
            }
        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            prodBox.ItemsSource = prodArray;
            string[] bikeTypes = { "All", "Male", "Female" };
            bikeCombo.ItemsSource = bikeTypes;
            bikeCombo.SelectedIndex = 0;
            
        }

        private void bikeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (bikeCombo.SelectedIndex==0)
            {
                prodBox.ItemsSource = prodArray;
            }
            else if (bikeCombo.SelectedIndex == 1)
            {
                int x = 0;
                for(int i = 0; i < prodArray.Length; i++)
                {
                    if (prodArray[i].varType == type1)
                    {
                        filteredArray[x] = prodArray[i];
                        x++;
                    }
                }
                prodBox.ItemsSource = filteredArray;
            }
            else if (bikeCombo.SelectedIndex == 2)
            {
                int x = 0;
                for (int i = 0; i < prodArray.Length; i++)
                {
                    if (prodArray[i].varType == type2)
                    {
                        filteredArray[x] = prodArray[i];
                        x++;
                    }
                }
                prodBox.ItemsSource = filteredArray;
            }
        }

        private void calcShippingButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Tax { get; set; }
        public Variation varType { get; set; }

        public void AddTax(double taxRate)
        {
            Tax = Price * taxRate;
        }

        public override string ToString()
        {
            return (String.Format("{0,-15}{1,-30}{2,-15}{3,-15}{4,-15}",ID,Name,Price,Tax,varType.VariationType));
        }
    }

    class Variation
    {
        public string VariationType { get; set; }
    }
}
