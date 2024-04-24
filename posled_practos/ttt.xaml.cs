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
    /// Логика взаимодействия для ttt.xaml
    /// </summary>
    public partial class ttt : Window
    {
        stranaTableAdapter adapter = new stranaTableAdapter();

        public ttt()
        {
            InitializeComponent();
            table_10.ItemsSource = adapter.GetData();

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<stranamodel> fro = LabaConverter.DeserializeObjext<List<stranamodel>>();
            foreach (var item in fro)
            {
                adapter.InsertQuery(item.strana);
            }
            table_10.ItemsSource = null;
            table_10.ItemsSource = adapter.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NaemPostxaml nn = new NaemPostxaml();
            nn.Show();
            Close();
        }
    }
}

