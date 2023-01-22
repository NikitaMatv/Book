using System;
using System.Collections.Generic;
using System.IO;
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
using Book.Component;
using Microsoft.Win32;

namespace Book.Pages
{
    /// <summary>
    /// Логика взаимодействия для BookPages.xaml
    /// </summary>
    public partial class BookPages : Page
    {
        public BookPages()
        {
            InitializeComponent();
            ListProduct.ItemsSource = App.DB.Books.ToList();
            var allTypes = App.DB.Postav.ToList();
            allTypes.Insert(0, new Postav
            {
                Name = "Все"
            });
            Filtr.ItemsSource = allTypes;
            Filtr.SelectedIndex = 0;
            Update();
           
        }
        private void Update()
        {

            var product = App.DB.Books.ToList();
            product = product.Where(p => p.Name.ToString().ToLower().Contains(SearchBox.Text.ToLower())).ToList();
            if (Filtr.SelectedIndex > 0)
            {
                var a = Filtr.SelectedIndex.ToString();
                product = product.Where(p => p.PostavId.ToString().ToLower().Contains(a.ToLower())).ToList();
            }
            if (Sortir.SelectedIndex > 0)
            {
                if (Sortir.SelectedIndex == 1)
                {
                    product = product.OrderBy(x => x.Price).ToList();
                }
                else if (Sortir.SelectedIndex == 2)
                {
                    product = product.OrderByDescending(x => x.Price).ToList();
                }
            }
            ListProduct.ItemsSource = product.ToList();
        }
        private void Filtr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void Sortir_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

     

        private void History_Click(object sender, RoutedEventArgs e)
        {

            var select = ListProduct.SelectedItem as Books;
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                select.Image = File.ReadAllBytes(dialog.FileName);
                DataContext = null;
                DataContext = select;
                App.DB.SaveChanges();
            }
            Update();
        }


    }
}
