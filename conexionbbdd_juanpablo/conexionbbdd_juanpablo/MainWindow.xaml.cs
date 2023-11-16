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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace conexionbbdd_juanpablo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SqlConnection miConexionSql;
        public MainWindow()
        {
            InitializeComponent();
            string miConexion = ConfigurationManager.ConnectionStrings["conexionbbdd_juanpablo.Properties.Settings.GestionEmpleadosConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);
            MuestraClientes();
        }

        public void MuestraClientes()
        {
            string consulta = "SELECT * FROM USUARIOS where Nombre='VICTOR';";
            SqlDataAdapter miAdapatadorSql = new SqlDataAdapter(consulta, miConexionSql);
            using (miAdapatadorSql)
            {
                DataTable clientesTabla = new DataTable();
                miAdapatadorSql.Fill(clientesTabla);

                ListaClientes.DisplayMemberPath = "nombre";
                ListaClientes.SelectedValuePath = "ID"; 
                ListaClientes.ItemsSource = clientesTabla.DefaultView;

            }
        }
    }
}
