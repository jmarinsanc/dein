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
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string dni { get; set; }
        public MainWindow()
        {
            InitializeComponent();

        }

        private void SeleccionarImagen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos|*.*";
            progressBar.Value = progressBar.Value+10;

            if (openFileDialog.ShowDialog() == true)
            {
                string rutaImagen = openFileDialog.FileName;

                // Cargar la imagen seleccionada en el control Image
                BitmapImage imagenBitmap = new BitmapImage(new Uri(rutaImagen));
                imagenPrevia.Source = imagenBitmap;
            }
        }

        private void boton_cancelar_Click(object sender, RoutedEventArgs e)
        {
            primera nuevaVentana = new primera();
            nuevaVentana.Show();
            nuevaVentana.boxnombre.Text = this.nombre;
            nuevaVentana.box_apellidos.Text = this.apellidos;
            nuevaVentana.box_email.Text = this.email;
            nuevaVentana.box_telefono.Text = this.telefono;
            nuevaVentana.box_dni.Text = this.dni;
            this.Close();
        }

        private void boton_guardar_Click(object sender, RoutedEventArgs e)
        {
            
            Empleado nuevoEmpleado = new Empleado(nombre, apellidos, email, telefono);
            datagrid.Items.Add(nuevoEmpleado);
            progressBar.Value = 100;


        }







        public class Empleado
        {
            public string nombre { get; set; }
            public string apellidos { get; set; }
            public string email { get; set; }
            public string telefono { get; set; }

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
            if(sender is TextBox textbox)
            {
                if(!String.IsNullOrWhiteSpace(textbox.Text))
                {
                    textbox.Text = "";
                }
                
            }
        }

        private void Txt_lostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textbox)
            {
                if (String.IsNullOrWhiteSpace(textbox.Text))
                {
                    if (textbox.Name == "box_direccion")
                    {
                        textbox.Text="Dirección";
                    }else if(textbox.Name == "box_ciudad"){
                        textbox.Text = "Ciudad";
                    }
                    else if(textbox.Name == "box_provincia")
                    textbox.Text = "Provincia";
                    else if (textbox.Name == "box_codigo")
                        textbox.Text = "Código Postal";
                    else if (textbox.Name == "box_pais")
                        textbox.Text = "País";
                }
            }
        }

        private void box_pais_MouseEnter(object sender, MouseEventArgs e)
        {
            if (box_pais.Text != "")
            {
                progressBar.Value = progressBar.Value + 10;
            }

        }

        private void box_redsocial_MouseEnter(object sender, MouseEventArgs e)
        {
            if (box_redsocial.Text != "")
            {
                progressBar.Value = progressBar.Value + 10;
            }

                

        }

        private void textBox_puesto_MouseEnter(object sender, MouseEventArgs e)
        {
            if (textBox_puesto.Text !="")
            {
                progressBar.Value = progressBar.Value + 10;
            }
        }
    }
}
