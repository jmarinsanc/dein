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

namespace GestionEmpleados2023
{
    /// <summary>
    /// Lógica de interacción para BuscarEmpleado.xaml
    /// </summary>
    public partial class BuscarEmpleado : Window
    {
        private GestioneEmpleados2023 gestionEmpleados;

        public BuscarEmpleado()
        {
            InitializeComponent();
            gestionEmpleados = new GestioneEmpleados2023();
        }

        private void BuscarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            string nombre = nombreTextbox.Text;
            string apellidos = apellidosTextbox.Text;
            bool esUsuario = esUsuarioCheckbox.IsChecked ?? false;
            int edad;

            // Validar y convertir la entrada de la edad a un entero
            if (!int.TryParse(edadTextBox.Text, out edad))
            {
                MessageBox.Show("Ingrese una edad válida.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Realizar la búsqueda del empleado en la base de datos
            List<Empleado> empleadosEncontrados = gestionEmpleados.BuscarEmpleado(nombre, apellidos, esUsuario, edad);

            // Mostrar los resultados en el DataGrid
            DataGrid.ItemsSource = empleadosEncontrados;
        }

        private void Volver_click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }
    }
}

