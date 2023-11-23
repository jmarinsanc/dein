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
using System.Windows.Shapes;
using System.IO;

namespace MotoRenting_Navarra
{
    /// <summary>
    /// Lógica de interacción para Convertidor.xaml
    /// </summary>
    public partial class Convertidor : Window
    {
        private bool seleccion = false;
        public Convertidor()
        {
            InitializeComponent();
        }
        private void Abrir_explorador(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new OpenFileDialog();

            // Establecer el filtro por extensiones de archivo
            openFileDialog.Filter = "Archivos GPX (*.gpx)|*.gpx|Archivos KML (*.kml)|*.kml|Archivos KMZ (*.kmz)|*.kmz|Archivos TCX (*.tcx)|*.tcx|Archivos NMEA (*.nmea)|*.nmea|Todos los archivos (*.*)|*.*";

            // Permitir la selección múltiple de archivos
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    // Hacer algo con los archivos seleccionados, por ejemplo, mostrar los nombres
                    MessageBox.Show($"Archivo seleccionado: {System.IO.Path.GetFileName(fileName)}");
                    seleccion = true;
                }
            }
        }

        private void convertir(object sender, RoutedEventArgs e)
        {
            if (seleccion == true)
            {
                MessageBox.Show("El archivo se ha convertido con éxito &#10 Pronto empezará la descarga;");
            }
            else
            {
                MessageBox.Show("Seleccione un archivo");
            }
        }
    }
}
