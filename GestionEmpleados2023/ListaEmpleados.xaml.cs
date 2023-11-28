using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Configuration;

namespace GestionEmpleados2023
{

    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public bool EsUsuario { get; set; }
        public int Edad { get; set; }
    }

    public partial class GestioneEmpleados2023                       
    {
        private SqlConnection ConexionConSql;

        public GestioneEmpleados2023()
        {
            EstablecerConexion();
        }

        private void EstablecerConexion()
        {
            string CadenaDeConexion = ConfigurationManager.ConnectionStrings["GestionEmpleados2023.Properties.Settings.GestionEmpleadosConnectionString"].ConnectionString;
            ConexionConSql = new SqlConnection(CadenaDeConexion);
        }

        public List<Empleado> ObtenerEmpleados()
        {
            EstablecerConexion();

            string consulta = "SELECT * FROM EMPLEADOS";
            DataTable Empleados = new DataTable();

            List<Empleado> listaEmpleados = new List<Empleado>();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, ConexionConSql);

            using (adaptador)
            {
                adaptador.Fill(Empleados);
            }

            listaEmpleados = Empleados.AsEnumerable().Select(row => new Empleado
            {
                Nombre = row.Field<string>("Nombre"),
                Apellidos = row.Field<string>("Apellidos"),
                EsUsuario = (row["EsUsuario"] != DBNull.Value) ? row.Field<bool>("EsUsuario") : false,
                Edad = row.Field<int>("Edad")

            }).ToList();

            return listaEmpleados;
        }
    }
    /// <summary>
    /// Lógica de interacción para ListaEmpleados.xaml
    /// </summary>
    public partial class ListaEmpleados : Window
    {
        private GestioneEmpleados2023 gestionEmpleados;
        public ListaEmpleados()
        {
            InitializeComponent();
            gestionEmpleados = new GestioneEmpleados2023();
            CargarEmpleadosEnDataGrid();
        }

        private void CargarEmpleadosEnDataGrid()
        {
            List<Empleado> empleados = gestionEmpleados.ObtenerEmpleados();
            dataGrid.ItemsSource = empleados;
        }
    }
}
