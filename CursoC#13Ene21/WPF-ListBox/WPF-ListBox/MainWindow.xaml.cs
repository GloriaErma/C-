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

namespace WPF_ListBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Poblacion> SourcePOB = new List<Poblacion>();
            SourcePOB.Add(new Poblacion() { Poblacion1 = "Madrid", Poblacion12 = "Barcelona", Temperatura1 =15, Temperatura12 =17, DiferenciaT = 2 });
            SourcePOB.Add(new Poblacion() { Poblacion1 = "Mosquera", Poblacion12 = "Bilbao", Temperatura1 = 19, Temperatura12 =27, DiferenciaT = 8 });
            SourcePOB.Add(new Poblacion() { Poblacion1 = "Málaga", Poblacion12 = "Belén", Temperatura1 = 5, Temperatura12 = 37, DiferenciaT = 32 });
            SourcePOB.Add(new Poblacion() { Poblacion1 = "Sevilla", Poblacion12 = "Claret", Temperatura1 = 22, Temperatura12 = 33, DiferenciaT = 11 });
            listaPoblacion.ItemsSource = SourcePOB;
        }
        // excepción NO selecciona elementos
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (listaPoblacion.SelectedItem != null){
                MessageBox.Show((listaPoblacion.SelectedItem as Poblacion).Poblacion1 + " " +
               (listaPoblacion.SelectedItem as Poblacion).Temperatura1 + " gC. Y " +
               (listaPoblacion.SelectedItem as Poblacion).Poblacion12 + " " +
               (listaPoblacion.SelectedItem as Poblacion).Temperatura12 + " gC. ");
            }
            else
            {
                MessageBox.Show("Por favor, Seleccione una fila/elemento!!!...");
            }
        }
        // Ejecute click de mouse en cuanrto elemento
        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (listaPoblacion.SelectedItem != null)
            {
                MessageBox.Show((listaPoblacion.SelectedItem as Poblacion).Poblacion1 + " " +
               (listaPoblacion.SelectedItem as Poblacion).Temperatura1 + " gC. Y " +
               (listaPoblacion.SelectedItem as Poblacion).Poblacion12 + " " +
               (listaPoblacion.SelectedItem as Poblacion).Temperatura12 + " gC. ");
            }
            else
            {
                MessageBox.Show("Por favor, Seleccione una fila/elemento!!!...");
            }
        }
    }
    // Propiedades...
    public class Poblacion
    {
        public string Poblacion1 { get; set; }
        public int Temperatura1 { get; set; }
        public string Poblacion12 { get; set; }
        public int Temperatura12 { get; set; }
        // Barra de Progreso
        public int DiferenciaT { get; set; }
}
}
