using Microsoft.Win32;
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

namespace formulario_de_juan_pablo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void SeleccionarImagen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string rutaImagen = openFileDialog.FileName;

                // Cargar la imagen seleccionada en el control Image
                BitmapImage imagenBitmap = new BitmapImage(new Uri(rutaImagen));
                imagenPrevia.Source = imagenBitmap;
            }
        }

        private void boton_guardar_Click(object sender, RoutedEventArgs e)
        {
            if (boxnombre.Text == "")
            {
                MessageBox.Show("El campo Nombre no puede estar vacío", "Error");
            }
            else if (box_apellidos.Text == "")
            {
                MessageBox.Show("El campo Apellidos no puede estar vacío", "Error");
            }
            else if (box_email.Text == "")
            {
                MessageBox.Show("El campo E-mail no puede estar vacío", "Error");
            }
            else if (box_telefono.Text == "")
            {
                MessageBox.Show("El campo Teléfono no puede estar vacío", "Error");
            }
            else
            {
                Empleado nuevoEmpleado = new Empleado(boxnombre.Text, box_apellidos.Text, box_email.Text, box_telefono.Text);


                datagrid.Items.Add(nuevoEmpleado);
            }


        }

        private void boton_cancelar_Click(object sender, RoutedEventArgs e)
        {

        }





        public class Empleado
        {
            private string nombre { get; set; }
            private string apellidos { get; set; }
            private string email { get; set; }
            private string telefono { get; set; }

            public Empleado(string nombre, string apellidos, string email, string telefono)
            {
                this.nombre = nombre;
                this.apellidos = apellidos;
                this.email = email;
                this.telefono = telefono;
            }
        }

        private void gotFocus(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(box_direccion.Text))
            {
                box_direccion.Text = "Dirección";
            }
            else if (String.IsNullOrWhiteSpace(box_ciudad.Text))
            {
                box_ciudad.Text = "";
            }
            else if (String.IsNullOrWhiteSpace(box_provincia.Text))
            {
                box_provincia.Text = "Provincia";
            }
            else if (String.IsNullOrWhiteSpace(box_codigo.Text))
            {
                box_codigo.Text = "Código Postal";

            }
            else if (String.IsNullOrWhiteSpace(box_pais.Text))
            {
                box_pais.Text = "País";
            }
        }
    }
}
