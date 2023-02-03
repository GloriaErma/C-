using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPresFund_ConexionGestionPedidos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // CREAR CADENA CONEXION
            // CoNfigurar CADENA CONEXION "", ASÍ;
            // 1-NOMBRE PROYECTO : WPresFund_ConexionGestionPedidos
            // 2.       ".Properties."
            // 3.       "Settings."
            // 4.       Cadena Conexión: "GeneralConnectionString"
            string Conexion = ConfigurationManager.ConnectionStrings["WPresFund_ConexionGestionPedidos.Properties.Settings.GeneralConnectionString"].ConnectionString;
            ConexionSQL = new SqlConnection(Conexion);
            MuestraCliente();
            MuestraTodosPedidos();


        }

        private void MuestraCliente()
        {
            try
            {
                string consulta = " SELECT * FROM CLIENTE";
                SqlDataAdapter AdaptaSQL = new SqlDataAdapter(consulta, ConexionSQL);
                using (AdaptaSQL)
                {
                    DataTable tablaCliente = new DataTable();
                    AdaptaSQL.Fill(tablaCliente);
                    ListaClientes.DisplayMemberPath = "nombre";  // información VER
                    ListaClientes.SelectedValuePath = "Id";      // campo clave Selcción elemento
                    ListaClientes.ItemsSource = tablaCliente.DefaultView;  // DONDE VIENE INFORMACIÓN
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MuestraPedidos()
        {
            try
            {
                // Espacio antes del    WHERE :::::"""""
                string consulta = "SELECT * FROM PEDIDO P INNER JOIN CLIENTE C ON C.ID=P.cCliente" +
                               " WHERE C.ID=@ClienteId";
                // instrución SQL con parametros::   recibe consultaSQLparametrica y conexión
                SqlCommand sqlParam = new SqlCommand(consulta, ConexionSQL);
                SqlDataAdapter AdaptaSQL = new SqlDataAdapter(sqlParam);
                using (AdaptaSQL)
                {
                    sqlParam.Parameters.AddWithValue("@ClienteId", ListaClientes.SelectedValue);
                    DataTable tablaPedidos = new DataTable();
                    AdaptaSQL.Fill(tablaPedidos);
                    pedidosCliente.DisplayMemberPath = "fechaPedido";  // información VER
                    pedidosCliente.SelectedValuePath = "Id";      // campo clave Selcción elemento
                    pedidosCliente.ItemsSource = tablaPedidos.DefaultView;  // DONDE VIENE INFORMACIÓN
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void MuestraTodosPedidos()
        {
            try
            {
                //string consulta = " SELECT * FROM PEDIDO";
                //string consulta = " SELECT CONCAT(cCliente,' - ',fechaPedido,' - ',FormaPago) AS INFOR FROM PEDIDO";
                string consulta = " SELECT *, CONCAT(cCliente,' - ',fechaPedido,' - ',FormaPago) AS INFOR FROM PEDIDO";

                SqlDataAdapter AdaptaSQL = new SqlDataAdapter(consulta, ConexionSQL);
                using (AdaptaSQL)
                {
                    DataTable tablaPedidos = new DataTable();
                    AdaptaSQL.Fill(tablaPedidos);
                    //TodosPedidos.DisplayMemberPath = "cCliente";  // información VER
                    TodosPedidos.DisplayMemberPath = "INFOR";  // información VER
                    TodosPedidos.SelectedValuePath = "Id";      // campo clave Selcción elemento
                    TodosPedidos.ItemsSource = tablaPedidos.DefaultView;  // DONDE VIENE INFORMACIÓN
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
          
        // instacia-objeto de clase
        SqlConnection ConexionSQL;

        // conflicto cuendo se db borrar un cliente, ya q este adecuado a SelectionChanged
        //  <ListBox Name="ListaClientes" HorizontalAlignment="Left" Height="207" Margin="15,92,0,0" VerticalAlignment="Top" Width="129" SelectionChanged="ListaClientes_SelectionChanged" />
        // e intenta listas pedidos del método MuestraPedidos().
        // cambiar evento
        //private void ListaClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    //MessageBox.Show("Clck en un cliente");
        //    MuestraPedidos();
        //}
        private void ListaClientes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MuestraPedidos();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("El Id de tabla Pedidos es: ",TodosPedidos.SelectedValue.ToString());  // muestra Object DB ser string.
            string consulta = "DELETE FROM PEDIDO WHERE ID=@pedidoId";
            SqlCommand botonSQL = new SqlCommand(consulta, ConexionSQL);
            ConexionSQL.Open();
            botonSQL.Parameters.AddWithValue("@pedidoId", TodosPedidos.SelectedValue);
            botonSQL.ExecuteNonQuery();
            ConexionSQL.Close();
            MuestraTodosPedidos();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("El Id de tabla Pedidos es: ",TodosPedidos.SelectedValue.ToString());  // muestra Object DB ser string.
            string consulta = "INSERT INTO CLIENTE (nombre) VALUES (@nombre)";
            SqlCommand botonSQL = new SqlCommand(consulta, ConexionSQL);
            ConexionSQL.Open();
            botonSQL.Parameters.AddWithValue("@nombre", InsertaCliente.Text);
            botonSQL.ExecuteNonQuery();
            ConexionSQL.Close();
            MuestraCliente();
            InsertaCliente.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("El Id de tabla Pedidos es: ",TodosPedidos.SelectedValue.ToString());  // muestra Object DB ser string.
            string consulta = "DELETE FROM CLIENTE WHERE ID=@clienteId";
            SqlCommand botonSQL = new SqlCommand(consulta, ConexionSQL);
            ConexionSQL.Open();
            botonSQL.Parameters.AddWithValue("@clienteId", ListaClientes.SelectedValue);
            botonSQL.ExecuteNonQuery();
            ConexionSQL.Close();
            MuestraCliente();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Actualizar ventanaAct = new Actualizar((int)ListaClientes.SelectedValue);
            //  2- forma OK comentario
            ventanaAct.Show();

            //  1- forma OK comentario
            // ventanaAct.Show();
            // muestra ventana forma modal
            // DETENIDO *************No ejecuta demás líneas
            //ventanaAct.ShowDialog();

            try
            {
                string consulta = " SELECT nombre FROM CLIENTE WHERE Id=@ClId";
                SqlCommand sqlCommand = new SqlCommand(consulta, ConexionSQL);
                SqlDataAdapter AdaptaSQL = new SqlDataAdapter(sqlCommand);
                using (AdaptaSQL)
                {
                    sqlCommand.Parameters.AddWithValue("@ClId", ListaClientes.SelectedValue);
                    DataTable tablaCliente = new DataTable();
                    AdaptaSQL.Fill(tablaCliente);
                    ventanaAct.CuadroActualizar.Text = tablaCliente.Rows[0]["nombre"].ToString();}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //   1- forma OK
            //ventanaAct.ShowDialog();
            //// muestra ventana forma modal
            //// DETENIDO *************No ejecuta demás líneas
            //MuestraCliente();


        }

         // <!--// 2- forma OK  utilizar evento ventana TOMA FOCO--> 
        private void Window_Activated(object sender, EventArgs e)
        {
            MuestraCliente();
        }
    }
}
