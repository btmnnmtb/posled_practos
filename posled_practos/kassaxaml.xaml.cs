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
    /// Логика взаимодействия для kassaxaml.xaml
    /// </summary>
    public partial class kassaxaml : Window
    {
        private uvEntities jocerr = new uvEntities();
        List<tab> tabbb = new List<tab>();
        public kassaxaml()
        {
            InitializeComponent();
            foreach (var item in jocerr.drag_camni.ToList())
            {
                tabbb.Add(new tab(item));
            }
            sklad.ItemsSource = tabbb;

           

        }

        private void cheakk_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }
        private void sklad_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (sklad.SelectedItem != null)
            {
                jocerr.postavchik.Remove(sklad.SelectedItem as postavchik);
                jocerr.SaveChanges();
                sklad.ItemsSource = jocerr.drag_camni.ToList();





            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sklad.SelectedItem != null)
            {
                
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window_for_uvelira_1 sa = new Window_for_uvelira_1();
            sa.Show();
            Close();
        }
    }
}
