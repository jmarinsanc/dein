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
    /// Lógica de interacción para Cuota.xaml
    /// </summary>
    public partial class Cuota : Window
    {
        
        public Cuota(string rutaImagen)
        {
            
            
            InitializeComponent();
            BitmapImage bitmap = new BitmapImage(new Uri(rutaImagen, UriKind.Relative));
            fotoCuota.Source = bitmap;


        }

        private void Ir_galeria(object sender, RoutedEventArgs e)
        {
            Galeria newGaleria = new Galeria();
            Window parentWindow = Window.GetWindow(this);

            if (parentWindow != null)
            {
                // Cerrar la ventana principal
                parentWindow.Close();
            }
            newGaleria.Show();
        }

        private void Ir_cuota(object sender, RoutedEventArgs e)
        {

        }

        private void Ir_Disponibilidad(object sender, RoutedEventArgs e)
        {
            Disponibilidad disponibilidad = new Disponibilidad();
            Window parentWindow = Window.GetWindow(this);

            if (parentWindow != null)
            {
                // Cerrar la ventana principal
                parentWindow.Close();
            }
            disponibilidad.Show();
        }

        private void Ir_resumen(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

        //    // Obtener la ruta de la imagen asociada al botón
        //    //string rutaImagen = ObtenerRutaImagen(fotoCuota.FindResource);

        //    // Crear la instancia de la ventana de cuota y pasar la ruta de la imagen
            Resumen ventanaCuota = new Resumen();
           this.Close();
           ventanaCuota.Show();

        }
        public void ActualizarImagen(string rutaImagen)
        {
            BitmapImage bitmap = new BitmapImage(new Uri(rutaImagen, UriKind.Relative));
            fotoCuota.Source = bitmap;
        }



    }
    
}
