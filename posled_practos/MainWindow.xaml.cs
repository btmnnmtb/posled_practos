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
using System.Windows.Navigation;
using System.Windows.Shapes;
using posled_practos.uvDataSetTableAdapters;

namespace posled_practos
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        polzovatelTableAdapter adapter = new polzovatelTableAdapter();
        public MainWindow()
        {


            InitializeComponent();
        }

        private void Butt(object sender, RoutedEventArgs e)
        {
            var all = adapter.GetData().Rows;
            for (int i = 0; i < all.Count; i++)
            {



                if (all[i][1].ToString() == Login.Text && all[i][2].ToString() == Pass.Password)
                {

                    int roleID = (int)all[i][3];
                    switch (roleID)
                    {
                        case 2:
                            Window1 role = new Window1();
                            role.Show();
                            Close();
                            break;
                        case 1:
                            Window2 seceod = new Window2();
                            seceod.Show();
                            Close();
                            break;



                    }

                    
                
                        


                    
                }
               










            }

        }
    }
}

