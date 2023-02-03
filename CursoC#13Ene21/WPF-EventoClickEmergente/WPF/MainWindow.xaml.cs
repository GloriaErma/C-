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

namespace WPF
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
            Grid objG = new Grid();
            this.Content = objG;        /// Grid dentro d ventana
            Button objB = new Button();  /// boton dentro de Grid
            objB.Width = 150;
            objB.Height = 75;
            objB.Background = Brushes.Blue;
            ///////////////////////
            WrapPanel objW = new WrapPanel();   // WrapPanel dentro d botón
            TextBlock objT0 = new TextBlock();
            objT0.Background = Brushes.Red;
            objT0.Foreground = Brushes.Yellow;  //color texto
            objT0.Text = "Click";
            objW.Children.Add(objT0);
            TextBlock objT1 = new TextBlock();
            objT1.Text = ":::DOS";
            objW.Children.Add(objT1);
            TextBlock objT2 = new TextBlock();
            objT2.Text = ":::TRES";
            objW.Children.Add(objT2);
            objB.Content = objW;

            objG.Children.Add(objB);    /// agrega botón a Grid
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Le has dado OK OK OK ");
            MessageBox.Show("Muy BIEN YA DISTE EL BOTON click");
        }

    }
}
