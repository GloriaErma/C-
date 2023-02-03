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

namespace WPF_DependencyProperty
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Propiedad Propia
        public int Propia
        {
            get { return (int) GetValue(miDependenciaProperty); }
            set { SetValue(miDependenciaProperty, value); }

        }
        // registra dependency property static: de clase NO intancias-Objetos
        public static readonly DependencyProperty miDependenciaProperty =
            DependencyProperty.Register("Propia", typeof(int), typeof(MainWindow), new PropertyMetadata(0));
        
        
        
        
        
        public MainWindow()
        {
            InitializeComponent();

        }
    }
}
