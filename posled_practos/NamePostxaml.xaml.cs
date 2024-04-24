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
    /// Логика взаимодействия для NamePostxaml.xaml
    /// </summary>
    public partial class NaemPostxaml : Window
    {
        private uvEntities po = new uvEntities();
        public NaemPostxaml()
        {
            InitializeComponent();
            table_7.ItemsSource = po.postavchik.ToList();
        }

        private void table_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (table_7.SelectedItem != null)
            {
               
                var selected = table_7.SelectedItem as postavchik;
                id.Text = Convert.ToString(selected.id_post);
                name.Text = selected.name_post;
                surname.Text = selected.surname_post;
                otch.Text = selected.otchestvo_post;
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            postavchik c = new postavchik();
            c.id_post = Convert.ToInt32(id.Text);
            c.name_post = name.Text;
            c.surname_post = surname.Text;
            c.otchestvo_post = otch.Text;
            po.postavchik.Add(c);
            po.SaveChanges();
            table_7.ItemsSource = po.postavchik.ToList();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ttt t = new ttt();
            t.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window_for_uvelira_1 gg = new Window_for_uvelira_1();   
            gg.Show();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            po.postavchik.Remove(table_7.SelectedItem as postavchik);
            po.SaveChanges();
            table_7.ItemsSource = po.postavchik.ToList();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (table_7.SelectedItem != null)
            {

                var selectedl = table_7.SelectedItem as postavchik;
                selectedl.id_post = Convert.ToInt32(id.Text);
                selectedl.name_post = name.Text;
                selectedl.surname_post = surname.Text;
                selectedl.otchestvo_post = otch.Text;
                po.SaveChanges();
                table_7.ItemsSource = po.postavchik.ToList();




            }
        }
    }
}

