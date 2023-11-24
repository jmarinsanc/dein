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

namespace MotoRenting_Navarra
{
    /// <summary>
    /// Lógica de interacción para Galeria.xaml
    /// </summary>
    public partial class Galeria : Window
    {
        static string rutaResumen;
        public static string rutaFoto;
        public Galeria()
        {
            InitializeComponent();
            //boxSearch.Text += Borrar_contenido;
        }

        private void Borrar_contenido(object sender, MouseEventArgs e)
        {
            if(sender is TextBox)
            {
                if (boxSearch.Text.Equals("Search"))
                {
                    boxSearch.Text = "";
                    boxSearch.Foreground = Brushes.Black;
                }
            }
            
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Calcular_Cuota(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            // Obtener la ruta de la imagen asociada al botón
            string rutaImagen = ObtenerRutaImagen(button.Name);
            rutaResumen = rutaImagen;

            // Crear la instancia de la ventana de cuota y pasar la ruta de la imagen
            Cuota ventanaCuota = new Cuota(rutaImagen);
            this.Close();
            ventanaCuota.Show();
        }

        private string ObtenerRutaImagen(string nombreBoton)
        {
            string rutaFoto = "";
            // Aquí puedes manejar diferentes casos según el nombre del botón
            // y devolver la ruta de la imagen correspondiente
            switch (nombreBoton)
            {
                case "botonYamaha":
                    rutaFoto = "/recursos/yamaha-tracer.png";
                    break;
                case "botonHonda":
                    rutaFoto = "/recursos/transalp.png";
                    break;
                case "botonVersys":
                    rutaFoto = "/recursos/versys.png";
                    break;
                case "botonDucati":
                    rutaFoto = "/recursos/multi.png";
                    break;
                // Agregar más casos para otros botones
                case "botonSuzuki":
                    rutaFoto = "/recursos/suzuki.png";
                    break;
                case "botonktm":
                    rutaFoto = "/recursos/ktm.png";
                    break;
                case "botonOtro":
                    rutaFoto = "/recursos/otro.png";
                    break;
                default:
                    rutaFoto = "/recursos/default.png"; // Ruta por defecto o error
                    break;
            }
            return rutaFoto;
        }





    }
}
