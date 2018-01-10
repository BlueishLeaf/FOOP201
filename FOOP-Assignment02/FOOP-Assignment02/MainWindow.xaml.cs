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

namespace FOOP_Assignment02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Declare Arrays of books and author
        Book[] booklist1 = new Book[3];
        Book[] booklist2 = new Book[3];
        Book[] booklist3 = new Book[3];
        Author[] authors = new Author[3];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void azBtn_Click(object sender, RoutedEventArgs e)
        {
            //Clear all Items(if coming from the search) and set itemsource to null to clear boxes
            bookListBox.ItemsSource = null;
            autListBox.ItemsSource = null;
            autListBox.Items.Clear();
            //Sort author array and set new itemsource to the sorted array
            Array.Sort(authors);
            autListBox.ItemsSource = authors;
        }

        private void zaBtn_Click(object sender, RoutedEventArgs e)
        {
            //Clear all Items(if coming from the search) and set itemsource to null to clear boxes
            bookListBox.ItemsSource = null;
            autListBox.ItemsSource = null;
            autListBox.Items.Clear();
            //Sort author array, reverse it, and set new itemsource to the sorted array
            Array.Sort(authors);
            Array.Reverse(authors);
            autListBox.ItemsSource = authors;
        }

        private void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            //Object instantiations
            Book b1 = new Book() { Title = "Bad Dad", Price = 5m, Pages = 300 };
            Book b2 = new Book() { Title = "The Worlds Worst Children", Price = 5.99m, Pages = 349 };
            Book b3 = new Book() { Title = "The Midnight Gang", Price = 5.49m, Pages = 288 };
            booklist1[0] = b1;
            booklist1[1] = b2;
            booklist1[2] = b3;
            Book b4 = new Book() { Title = "Georges Marvellous Medicine", Price = 4.99m, Pages = 292 };
            Book b5 = new Book() { Title = "The Enormous Crocodile", Price = 4.49m, Pages = 265 };
            Book b6 = new Book() { Title = "The Twits", Price = 3.5m, Pages = 245 };
            booklist2[0] = b4;
            booklist2[1] = b5;
            booklist2[2] = b6;
            Book b7 = new Book() { Title = "Fantastic Beasts and Where to Find Them", Price = 12, Pages = 459 };
            Book b8 = new Book() { Title = "Harry Potter and the Prizoner of Azkaban", Price = 9.99m, Pages = 564 };
            Book b9 = new Book() { Title = "Harry Potter and the Philospohers Stone", Price = 3.72m, Pages = 654 };
            booklist3[0] = b7;
            booklist3[1] = b8;
            booklist3[2] = b9;
            Author a1 = new Author() { FirstName = "David", LastName = "Walliams", Collection = booklist1 };
            Author a2 = new Author() { FirstName = "Roald", LastName = "Dahl", Collection = booklist2 };
            Author a3 = new Author() { FirstName = "JK", LastName = "Rowling", Collection = booklist3 };
            authors[0] = a1;
            authors[1] = a2;
            authors[2] = a3;
            //Set initial itemsource of the author box to the author array
            autListBox.ItemsSource = authors;
        }

        private void autListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //When selection changes, get the books of the selected author, as long as it isnt null
            bookListBox.ItemsSource = null;
            Author selectedAuthor = autListBox.SelectedItem as Author;
            if (selectedAuthor != null)
            {
                bookListBox.ItemsSource = selectedAuthor.Collection;
            }
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = searchBox.Text;
            bookListBox.ItemsSource = null;
            autListBox.ItemsSource = null;
            //Filtered array declarations
            Author[] filteredAuthors = new Author[authors.Length];
            Book[] filteredBooks = new Book[booklist1.Length + booklist2.Length + booklist3.Length];
            int i = 0;
            //Loop through all authors and check if the search term matches either the
            //first name or last name, then add it to the array.
            for (int x = 0; x < authors.Length; x++)
            {
                if (authors[x].FirstName.ToLower() == searchTerm.ToLower() || authors[x].LastName.ToLower() == searchTerm.ToLower())
                {
                    filteredAuthors[i] = authors[x];
                    i++;
                }
            }
            //Check to see if an author was found at all, otherwise moves on to checking the books
            if (filteredAuthors[0] != null)
            {
                autListBox.ItemsSource = filteredAuthors;
                bookListBox.ItemsSource = filteredAuthors[0].Collection;
            }
            else
            {
                //Loop through each booklist finding each book who's title contains the search term
                //and adds it to an array.
                int j = 0;
                for (int x = 0; x < booklist1.Length; x++)
                {
                    if (booklist1[x].Title.ToLower().Contains(searchTerm.ToLower()))
                    {
                        filteredBooks[j] = booklist1[x];
                        j++;
                    }
                }
                for (int x = 0; x < booklist2.Length; x++)
                {
                    if (booklist2[x].Title.ToLower().Contains(searchTerm.ToLower()))
                    {
                        filteredBooks[j] = booklist2[x];
                        j++;
                    }
                }
                for (int x = 0; x < booklist3.Length; x++)
                {
                    if (booklist3[x].Title.ToLower().Contains(searchTerm.ToLower()))
                    {
                        filteredBooks[j] = booklist3[x];
                        j++;
                    }
                }
                //Sets itemsource to null so that "items.add" can be used to show the search term in
                //the author box as per the example
                autListBox.ItemsSource = null;
                autListBox.Items.Add(searchTerm);
                bookListBox.ItemsSource = filteredBooks;
            }
        }
    }
}
