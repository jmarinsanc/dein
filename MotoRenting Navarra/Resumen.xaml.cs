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
    /// Lógica de interacción para Resumen.xaml
    /// </summary>
    public partial class Resumen : Window
    {
        public Resumen()
        {
            InitializeComponent();
            BitmapImage bitmap = new BitmapImage(new Uri(Galeria.rutaFoto, UriKind.Relative));
            foto.Source = bitmap;
        }

        private void Calcular_Cuota(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            // Obtener la ruta de la imagen asociada al botón
            string rutaImagen = Galeria.rutaFoto;

            // Obtener la instancia existente de la ventana Cuota si existe
            Cuota ventanaCuota = Application.Current.Windows.OfType<Cuota>().FirstOrDefault();

            if (ventanaCuota != null)
            {
                // Actualizar la imagen en la ventana Cuota
                ventanaCuota.ActualizarImagen(rutaImagen);
            }
            else
            {
                // Si no existe, crear una nueva instancia de Cuota y mostrarla
                ventanaCuota = new Cuota(rutaImagen);
                ventanaCuota.Show();
            }
            this.Close();
        }
        public void ActualizarImagen()
        {
            BitmapImage bitmap = new BitmapImage(new Uri(Galeria.rutaFoto, UriKind.Relative));
            foto.Source = bitmap;
        }

    }
}
