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

namespace Assignment02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Member[] memArray = new Member[4];
        Member[] filteredArray = new Member[4];
        MembershipType fullType = new MembershipType { Type = "Full" };
        MembershipType offPeakType = new MembershipType { Type = "Off Peak" };
        MembershipType studentType = new MembershipType { Type = "Student" };
        MembershipType oapType = new MembershipType { Type = "OAP" };


        public MainWindow()
        {
            InitializeComponent();
            Random random = new Random();
            Member mem0 = new Member { Name = "Juan Smith", Phone = "0877767878", Address = "321 Testland", MemType = studentType, JoinYear = random.Next(2000, 2016) };
            Member mem1 = new Member { Name = "John Smith", Phone = "0877777777", Address = "Henlo this is the address", MemType = oapType, JoinYear = random.Next(2000, 2016) };
            Member mem2 = new Member { Name = "Will Smith", Phone = "0866642022", Address = "TestAddress", MemType = fullType, JoinYear = random.Next(2000, 2016) };
            Member mem3 = new Member { Name = "Jaden SMith", Phone = "0869694202", Address = "new address whu this?", MemType = offPeakType, JoinYear = random.Next(2000, 2016) };
            memArray[0] = mem0;
            memArray[1] = mem1;
            memArray[2] = mem2;
            memArray[3] = mem3;

        }

        private void memberList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Member selectedMember = memberList.SelectedItem as Member;
            nameBlock.Text = selectedMember.Name;
            phoneBlock.Text = selectedMember.Phone;
            addBlock.Text = selectedMember.Address;
            typeBlock.Text = selectedMember.MemType.Type;
            yearBlock.Text = selectedMember.JoinYear.ToString();

        }

        private void typeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            memberList.ItemsSource = "";
            int x = 0;
            switch (typeComboBox.SelectedIndex)
            {
                case 0:
                    memberList.ItemsSource = memArray;
                    break;
                case 1:
                    for (int i = 0; i < memArray.Length; i++)
                    {
                        if (memArray[i].MemType == fullType)
                        {
                            filteredArray[x] = memArray[i];
                            x++;
                        }
                    }
                    memberList.ItemsSource = filteredArray;
                    break;
                case 2:
                    for (int i = 0; i < memArray.Length; i++)
                    {
                        if (memArray[i].MemType == offPeakType)
                        {
                            filteredArray[x] = memArray[i];
                            x++;
                        }
                    }
                    memberList.ItemsSource = filteredArray;
                    break;
                case 3:
                    for (int i = 0; i < memArray.Length; i++)
                    {
                        if (memArray[i].MemType == studentType)
                        {
                            filteredArray[x] = memArray[i];
                            x++;
                        }
                    }
                    memberList.ItemsSource = filteredArray;
                    break;
                case 4:
                    for (int i = 0; i < memArray.Length; i++)
                    {
                        if (memArray[i].MemType == oapType)
                        {
                            filteredArray[x] = memArray[i];
                            x++;
                        }
                    }
                    memberList.ItemsSource = filteredArray;
                    break;

            }
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            memberList.ItemsSource = "";
            string searchName = searchBox.Text;
            int x = 0;
            for(int i = 0; i < memArray.Length; i++)
            {
                if (searchName == memArray[i].Name)
                {
                    filteredArray[x] = memArray[i];
                    x++;
                }
            }
            memberList.ItemsSource = filteredArray;
        }

        private void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            memberList.ItemsSource = memArray;
            string[] memTypes = { "All","Full", "Off Peak", "Student", "OAP" };
            typeComboBox.ItemsSource = memTypes;
            typeComboBox.SelectedIndex = 0;
        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
