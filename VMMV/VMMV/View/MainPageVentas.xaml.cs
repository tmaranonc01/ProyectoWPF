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

namespace VMMV.View
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class MainPageVentas : Window
    {
        public MainPageVentas()
        {
            InitializeComponent();
        }

        private void Button_Click_Articulos(object sender, RoutedEventArgs e)
        {
            MainPageArticulos articulos = new MainPageArticulos();
            articulos.Show();
            this.Close();
        }

        private void Button_Click_Dependientes(object sender, RoutedEventArgs e)
        {
            MainPageDependientes dependientes = new MainPageDependientes();
            dependientes.Show();
            this.Close();
        }
    }
}
