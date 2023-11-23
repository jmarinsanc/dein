using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Lógica de interacción para footer.xaml
    /// </summary>
    public partial class footer : UserControl
    {
        public footer()
        {
            InitializeComponent();
        }

        private void Ir_Home(object sender, RoutedEventArgs e)
        {
            UserControl1 user = new UserControl1();
            Window parentWindow = Window.GetWindow(this);
            user.Ir_Home(sender, e);

            if (parentWindow != null)
            {
                // Cerrar la ventana principal
                parentWindow.Close();
            }

            
            
            
        }

        private void Image_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void ir_contacto(object sender, RoutedEventArgs e)
        {
            Contacto contacto = new Contacto();
            Window parentWindow = Window.GetWindow(this);

            if (parentWindow != null)
            {
                // Cerrar la ventana principal
                parentWindow.Close();
            }
            contacto.Show();

        }
        public void AbrirGoogleMaps(string direccion)
        {
            direccion = direccion.Replace(" ", "+");
            string url = $"https://www.google.com/maps?q={direccion}";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir Google Maps. Error: {ex.Message}");
            }
        }

        public void ButtonDireccion_Click(object sender, RoutedEventArgs e)
        {
            string direccion = "av bayona 12, pamplona"; // Dirección deseada
            AbrirGoogleMaps(direccion);
        }

        public void AbrirPaginaWeb(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir la página web. Error: {ex.Message}");
            }
        }

        private void ImagenRedSocial_Click(object sender, RoutedEventArgs e)
        {
            string url = "";

            if (sender == ImageFacebook)
            {
                url = "https://www.facebook.com"; // Reemplaza con tu URL de Facebook
            }
            else if (sender == ImageInstagram)
            {
                url = "https://www.instagram.com"; // Reemplaza con tu URL de Instagram
            }
            else if (sender == ImageTwitter)
            {
                url = "https://www.twitter.com"; // Reemplaza con tu URL de Twitter
            }
            else if (sender == ImageYoutube)
            {
                url = "https://www.youtube.com"; // Reemplaza con tu URL de YouTube
            }

            AbrirPaginaWeb(url);
        }


    }
}
