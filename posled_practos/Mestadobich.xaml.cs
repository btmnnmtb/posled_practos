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
    /// Логика взаимодействия для Mestadobich.xaml
    /// </summary>
    public partial class Mestadobich : Window
    {
        private uvEntities mesto = new uvEntities();
        List<mest> mestos = new List<mest>();

        public Mestadobich()
        {
            InitializeComponent();

            table_6.ItemsSource = mesto.mesto_dobich.ToList();


        }

        private void table_5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(table_6.SelectedItem != null)
            {
                var sell = table_6.SelectedItem as mesto_dobich;
                countryid.Text = Convert.ToString(sell.country_id);
                post.Text = Convert.ToString(sell.post_dost_id);
                mestodobi.Text = sell.mesto_dobich1;
                

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Добавить
            mesto_dobich qq = new mesto_dobich();
            qq.country_id = Convert.ToInt32(countryid.Text);
            qq.post_dost_id = Convert.ToInt32(post.Text);
            qq.mesto_dobich1 = mestodobi.Text;
            mesto.mesto_dobich.Add(qq);
            mesto.SaveChanges();
            table_6.ItemsSource = mesto.mesto_dobich.ToList();





        }



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window2 pp = new Window2();
            pp.Show();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow ww = new MainWindow();
            ww.Show();
            Close();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window3 xx = new Window3();
            xx.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (table_6.SelectedItem != null)
            {
                var selll = table_6.SelectedItem as mesto_dobich;
                selll.country_id = Convert.ToInt32(countryid.Text);
                selll.post_dost_id = Convert.ToInt32(post.Text);

                selll.mesto_dobich1 = mestodobi.Text;
                mesto.SaveChanges();
                table_6.ItemsSource = mesto.mesto_dobich.ToList();



            }

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (table_6.SelectedItem != null)
            {
                mesto.mesto_dobich.Remove(table_6.SelectedItem as mesto_dobich);
                mesto.SaveChanges();
                table_6.ItemsSource = mesto.mesto_dobich.ToList();

            }
        }
    }
}

