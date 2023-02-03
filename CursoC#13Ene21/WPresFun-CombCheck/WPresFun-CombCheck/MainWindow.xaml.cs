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

namespace WPresFun_CombCheck
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Capital> ListaCapital = new List<Capital>();
            ListaCapital.Add(new Capital { NombreCapital = "Madrid" });
            ListaCapital.Add(new Capital { NombreCapital = "Bogotá" });
            ListaCapital.Add(new Capital { NombreCapital = "Lima" });
            ListaCapital.Add(new Capital { NombreCapital = "DF" });
            ListaCapital.Add(new Capital { NombreCapital = "Santiago" });

            Capital.ItemsSource = ListaCapital;
        }
        //<!--Este checontrole los otros check-->
        // pulsar check y activa todos ck 
        private void Todas_Checked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = true;
            Bogota.IsChecked = true;
            Lima.IsChecked = true;
            DF.IsChecked = true;
            Santiago.IsChecked = true;
        }
        private void Todas_Unchecked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = false;
            Bogota.IsChecked = false;
            Lima.IsChecked = false;
            DF.IsChecked = false;
            Santiago.IsChecked = false;
        }
        private void Individual_Unchecked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == true && Bogota.IsChecked == true && Lima.IsChecked == true &&
                 DF.IsChecked == true && Santiago.IsChecked == true)
            {
                Todas.IsChecked = true;
            }
            else
            {
                Todas.IsChecked = null; // tercer estado;
            }
        }

        private void M_Unchecked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == false && Bogota.IsChecked == false && Lima.IsChecked == false &&
                DF.IsChecked == false && Santiago.IsChecked == false)
            {
                Todas.IsChecked = false;
            }
            else
            {
                Todas.IsChecked = null; // tercer estado;
            }
        }
    }
    public class Capital
    {
        public string NombreCapital { get; set; }

    }
}
