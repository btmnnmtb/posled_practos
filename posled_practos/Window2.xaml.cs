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
using System.Windows.Shapes;

namespace posled_practos
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private uvEntities gotham = new uvEntities();

        public Window2()
        {
            InitializeComponent();
            table_5.ItemsSource = gotham.strana.ToList();
            txtt.TextChanged += txtt_TextChanged;
        }

        private void table_5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (table_5.SelectedItem != null)
            {
                var selected = table_5.SelectedItem as strana;
                txtt.Text = selected.strana1;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Добавление
            strana str = new strana();
            

            
            gotham.strana.Add(str);
            gotham.SaveChanges();
            table_5.ItemsSource = gotham.strana.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Удаление
            if (table_5.SelectedItem != null)
            {
                gotham.strana.Remove(table_5.SelectedItem as strana);
                gotham.SaveChanges();
                table_5.ItemsSource = gotham.strana.ToList();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Mestadobich oo = new Mestadobich();
            oo.Show();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            // Выййти в окно авторизации 
            MainWindow l = new MainWindow();
            l.Show();
            Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (table_5.SelectedItem != null)
            {
                var slected = table_5.SelectedItem as strana;
                slected.strana1 = txtt.Text;
                gotham.SaveChanges();
                table_5.ItemsSource = gotham.strana.ToList();
            }
        }

        private void txtt_TextChanged(object sender, TextChangedEventArgs e)
        {
            {
                
                
            }

        }
    }
}

