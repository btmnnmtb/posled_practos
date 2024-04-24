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
    /// Логика взаимодействия для Window_for_uvelira_1.xaml
    /// </summary>
    public partial class Window_for_uvelira_1 : Window
    {
        private uvEntities jocer = new uvEntities();
        List<tab> tabb = new List<tab>();

        public Window_for_uvelira_1()
        {
            InitializeComponent();
            
            table_3.ItemsSource = jocer.drag_camni.ToList();
            combo.ItemsSource = jocer.drag_camni.ToList();

        }

        private void table_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (table_3.SelectedItem != null)
            {
                var selec = table_3.SelectedItem as drag_camni;
                name_of_cam.Text = selec.name_camni;
                mesto_dobichh_id.Text = Convert.ToString(selec.mesto_dobich_id);
                camen_id.Text = Convert.ToString(selec.camen_id);
                otchitka.Text = Convert.ToString(selec.ochis_kamen);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Переход на предыдущию страницу
            Window1 ll = new Window1();
            ll.Show();
            Close();



        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Поиск

            table_3.ItemsSource = jocer.drag_camni.ToList().Where(item => item.name_camni.Contains(poisk.Text));


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Добавить 
            drag_camni cc = new drag_camni();
            cc.name_camni = name_of_cam.Text;
            cc.ochis_kamen = Convert.ToInt32(otchitka.Text);



            cc.camen_id = Convert.ToInt32(camen_id.Text);
            cc.mesto_dobich_id = Convert.ToInt32(mesto_dobichh_id.Text);
            jocer.drag_camni.Add(cc);

            jocer.SaveChanges();
            table_3.ItemsSource = jocer.drag_camni.ToList();



        }



        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NaemPostxaml ee = new NaemPostxaml();
            ee.Show();
            Close();
        }

        private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (combo.SelectedItem != null)
            {
                var selecteddd = combo.SelectedItem as mesto_dobich;
                table_3.ItemsSource = jocer.drag_camni.ToList().Where(item => item.mesto_dobich == selecteddd);
                

            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            table_3.ItemsSource = jocer.drag_camni.ToList();

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (table_3.SelectedItem != null)
            {

                var selecc = table_3.SelectedItem as drag_camni;
                selecc.name_camni = name_of_cam.Text;
                selecc.mesto_dobich_id = Convert.ToInt32(mesto_dobichh_id.Text);
                selecc.camen_id = Convert.ToInt32(camen_id.Text);       
                selecc.ochis_kamen = Convert.ToInt32(otchitka.Text);
                jocer.SaveChanges();
                table_3.ItemsSource = jocer.drag_camni.ToList();



            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (table_3.SelectedItem != null) 
            {
                jocer.drag_camni.Remove(table_3.SelectedItem as drag_camni);
                jocer.SaveChanges();
                table_3.ItemsSource = jocer.drag_camni.ToList();
                
            }
        }
    }

    
}
