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
    /// Lógica de interacción para SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        private bool sesion = false;
        public SignUp()
        {
            InitializeComponent();
        }

        private void ir_Login(object sender, RoutedEventArgs e)
        {
            Login log = new Login();
            Window parentWindow = Window.GetWindow(this);

            if (parentWindow != null)
            {
                // Cerrar la ventana principal
                parentWindow.Close();
            }
            log.Show();
        }

        private void ir_privacidad(object sender, RoutedEventArgs e)
        {
            Privacidad priva = new Privacidad();
            Window parentWindow = Window.GetWindow(this);

            if (parentWindow != null)
            {
                // Cerrar la ventana principal
                parentWindow.Close();
            }
            priva.Show();
        }

        private void Crear_cuenta(object sender, RoutedEventArgs e)
        {
            
            if (boxCorreo.Text == "")
            {
                MessageBox.Show("El campo Correo no puede estar vacío", "Error");
            }
            else if (contraseña.Text == "")
            {
                MessageBox.Show("El campo Contraseña no puede estar vacío", "Error");
            }
            else if (boxedad.Text == "")
            {
                MessageBox.Show("El campo Edad no puede estar vacío", "Error");
            }
            else if (comboCarne.SelectedItem == null)
            {
                MessageBox.Show("Selecciona tu tipo de carné", "Error");
            }
            else
            {
                if (sesion)
                {
                    MessageBox.Show("Esta cuenta ya existe", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Cuenta creada con éxito", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                    sesion = true;
                }

            }

            
        }
    
    }
}
