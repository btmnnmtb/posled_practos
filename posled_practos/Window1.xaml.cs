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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private uvEntities batman = new uvEntities();
        //uveliriTableAdapter uvvelir = new uveliriTableAdapter(); 
        public Window1()
        {
            InitializeComponent();


            table_1.ItemsSource = batman.uveliri.ToList();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window_for_uvelira_1 okno = new Window_for_uvelira_1();
            okno.Show();
            Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //удалить
            if (table_1.SelectedItem != null)
            {
                batman.uveliri.Remove(table_1.SelectedItem as uveliri);
                batman.SaveChanges();
                table_1.ItemsSource = batman.uveliri.ToList();
            }

        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Добавить
            uveliri c = new uveliri();
            c.id_uveliri = Convert.ToInt32(id.Text);
            c.name_uveliri = name.Text;
            c.surname_uvelriri = surname.Text;
            c.otchestvo_uvelri = surname.Text;
            batman.uveliri.Add(c);
            batman.SaveChanges();
            table_1.ItemsSource = batman.uveliri.ToList();
        }
        private void table_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (table_1.SelectedItem != null)
            {
                var selected = table_1.SelectedItem as uveliri;
                id.Text = Convert.ToString(selected.id_uveliri);
                name.Text = selected.name_uveliri;
                surname.Text = selected.surname_uvelriri;
                otch.Text = selected.otchestvo_uvelri;
            }
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow kk = new MainWindow();
            kk.Show();
            Close();
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if(table_1.SelectedItem != null)
            {
                var sel = table_1.SelectedItem as uveliri;
                sel.id_uveliri = Convert.ToInt32(id.Text);
                sel.name_uveliri = name.Text;
                sel.surname_uvelriri = surname.Text;
                sel.otchestvo_uvelri = otch.Text;   
                batman.SaveChanges();
                table_1.ItemsSource = batman.uveliri.ToList();
            }
        }
    }
}

