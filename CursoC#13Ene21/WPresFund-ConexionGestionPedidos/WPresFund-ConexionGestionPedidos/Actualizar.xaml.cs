using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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


namespace WPresFund_ConexionGestionPedidos
{
    /// <summary>
    /// Lógica de interacción para Actualizar.xaml
    /// </summary>
    public partial class Actualizar : Window
    {
        // instacia-objeto de clase
        SqlConnection ConexionSQL;
        private int z;

        // pasar x PARAMETRO INFORMACION DE una ventana a otra
        public Actualizar(int ID)
        {
            InitializeComponent();
            z = ID;
            string Conexion = ConfigurationManager.ConnectionStrings["WPresFund_ConexionGestionPedidos.Properties.Settings.GeneralConnectionString"].ConnectionString;
            ConexionSQL = new SqlConnection(Conexion);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("El Id de tabla Pedidos es: ",TodosPedidos.SelectedValue.ToString());  // muestra Object DB ser string.
            string consulta = "UPDATE CLIENTE SET nombre=@nombre WHERE Id=" + z ;
            SqlCommand botonSQL = new SqlCommand(consulta, ConexionSQL);
            ConexionSQL.Open();
            botonSQL.Parameters.AddWithValue("@nombre", CuadroActualizar.Text);
            botonSQL.ExecuteNonQuery();
            ConexionSQL.Close();
            // cerrar clase ventana
            this.Close();
           
        }
    }
}
