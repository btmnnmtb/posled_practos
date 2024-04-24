using posled_practos.uvDataSetTableAdapters;
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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        uveliriTableAdapter adapter1 = new uveliriTableAdapter();
        public Window3()
        {
            InitializeComponent();
            table_12.ItemsSource = adapter1.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<uvelirmodel> fro = LabaConverter.DeserializeObjext<List<uvelirmodel>>();
            foreach (var item in fro)
            {
                adapter1.InsertQueryy(item.id, item.name_uveliri, item.surname_uveliri, item.otchestvo_uvelri);
            }
            table_12.ItemsSource = null;
            table_12.ItemsSource = adapter1.GetData();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Mestadobich ff = new Mestadobich();
            ff.Show();
            Close();
        }
    }
}

