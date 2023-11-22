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

namespace MotoRenting_Navarra
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mediaElement.MediaOpened += MediaElement_MediaOpened;
        }

        private void MediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            // El archivo multimedia se ha cargado correctamente y está listo para reproducirse
            // Puedes realizar acciones aquí, como obtener la duración del video
            TimeSpan duration = mediaElement.NaturalDuration.TimeSpan;
            // Haz algo con la duración del video
        }
    

        private void UserControl1_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void MouseLeave_boton(object sender, MouseEventArgs e)
        {
            if (sender is Button boton)
            {
                // Cambiar el color de fondo del botón
                boton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("black"));
            }
        }

        private void MouseEnter_boton(object sender, RoutedEventArgs e)
        {
            if (sender is Button boton)
            {
                // Cambiar el color de fondo del botón
                boton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D5C7BC"));
            }
        }


    }
}
