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
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            home.MouseEnter += MouseEnter_boton;
            home.MouseLeave += MouseLeave_boton;
        }



        private void MouseEnter_boton(object sender, MouseEventArgs e)
        {
            if (sender is Button boton)
            {
                // Cambiar el color de fondo del botón
                boton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D5C7BC"));
            }
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

        private void ir_convertidor(object sender, RoutedEventArgs e)
        {
            Convertidor conver = new Convertidor();
            Window parentWindow = Window.GetWindow(this);

            if (parentWindow != null)
            {
                // Cerrar la ventana principal
                parentWindow.Close();
            }
            conver.Show();

        }

        public void Ir_Home(object sender, RoutedEventArgs e)
        {
            MainWindow home = new MainWindow();
            Window parentWindow = Window.GetWindow(this);

            if (parentWindow != null)
            {
                // Cerrar la ventana principal
                parentWindow.Close();
            }
            home.Show();


        }
    }
}
