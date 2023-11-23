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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private bool sesion = false;
        public Login()
        {
            InitializeComponent();
        }

        private void ir_SignUp(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();

            Window parentWindow = Window.GetWindow(this);
            

            if (parentWindow != null)
            {
                // Cerrar la ventana principal
                parentWindow.Close();
            }
            signUp.Show();
        }

        private void iniciarSesion(object sender, RoutedEventArgs e)
        {
            if (sesion)
            {
                MessageBox.Show("La sesión ya está iniciada", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);





            }
            else
            {
                if (boxCorreo.Text == "")
                {
                    MessageBox.Show("El campo Correo no puede estar vacío", "Error");
                }
                else if (contraseña.Text == "")
                {
                    MessageBox.Show("El campo Contraseña no puede estar vacío", "Error");
                }

                else
                {

                    if (sesion)
                    {
                        MessageBox.Show("La sesión ya está iniciada", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sesión iniciada con éxito", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
                        sesion = true;
                        boxCorreo.Text = "";
                        contraseña.Text = "";
                    }
                }
            }
        }
    }
}
