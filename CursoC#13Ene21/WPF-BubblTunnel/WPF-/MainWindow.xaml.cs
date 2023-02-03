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

namespace WPF_
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ///////////////////////////////////////////////////////////////////////////
            /////  es prioridad este codigo vs. MainWindow.xaml en XAML y Diseño
            /// 
           
        }
        /// <summary>
        ///  1. EVENTO BUBBLING, HACIA ARRIBA
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Le has dado BOTON OK OK OK ");
            MessageBox.Show("Muy BIEN YA DISTE EL BOTON click");
        }
        ///  2. EVENTO BUBBLING, HACIA ARRIBA  -- SEGUNDO
        //private void StackPanel_Click(object sender, RoutedEventArgs e)
        //{
        //    Console.WriteLine("Le has dado PANEL OK OK ");
        //}
        ///  2. EVENTO TUNNELING, HACIA ABAJO -- PRIMERO
        private void StackPanel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Le has dado PANEL OK OK ");
        }
    }
}
