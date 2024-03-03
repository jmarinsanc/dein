using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace formulario_de_juan_pablo
{
    /// <summary>
    /// Lógica de interacción para primera.xaml
    /// </summary>
    public partial class primera : Window
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string dni { get; set; }

        public primera()
        {
            InitializeComponent();
            nombre = boxnombre.Text;
            apellidos = box_apellidos.Text;
            email = box_email.Text;
            telefono = box_telefono.Text;
            dni = box_dni.Text;
        }

        private void Button_Cancelar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Guardar(object sender, RoutedEventArgs e)
        {
            if (boxnombre.Text == "")
            {
                MessageBox.Show("El campo Nombre no puede estar vacío", "Error");
            }
            else if (box_apellidos.Text == "")
            {
                MessageBox.Show("El campo Apellidos no puede estar vacío", "Error");
            }
            else if (!Regex.IsMatch(box_email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El campo E-mail no puede estar vacío o formato incorrecto", "Error");
            }
            else if (!Regex.IsMatch(box_telefono.Text, @"^\d{9}$"))
            {
                MessageBox.Show("El campo Teléfono no puede estar vacío o debe tener 9 dígitos", "Error");
            }
            else
            {
                MainWindow main = new MainWindow();
                main.nombre = boxnombre.Text;
                main.apellidos = box_apellidos.Text;
                main.email = box_email.Text;
                main.telefono = box_telefono.Text;
                main.Show();
                this.Close();
            }

   
        }

        private void box_dni_MouseEnter(object sender, MouseEventArgs e)
        {
            if ( boxnombre.Text != "" && box_email.Text != "" && box_apellidos.Text != "" && box_telefono.Text != "")
            {
                progressBar.Value = 60;

            }


        }

        private void boxnombre_MouseEnter(object sender, MouseEventArgs e)
        {
            if (boxnombre.Text == "" && progressBar.Value == 0)
            {
                progressBar.Value = progressBar.Value + 10;

            }

        }

        private void box_apellidos_MouseEnter(object sender, MouseEventArgs e)
        {
            if (progressBar.Value == 10 && boxnombre.Text !="")
            {
                progressBar.Value = progressBar.Value + 10;

            }

        }

        private void box_email_MouseEnter(object sender, MouseEventArgs e)
        {
            if ( boxnombre.Text != "" && box_apellidos.Text!="")
            {
                progressBar.Value = 30;

            }

        }

        private void box_telefono_MouseEnter(object sender, MouseEventArgs e)
        {
            if (box_telefono.Text == "" && boxnombre.Text != "" && box_email.Text !="" && box_apellidos.Text != "")
            {
                progressBar.Value = 40;

            }

        }

        private void fecha_nacimiento_MouseEnter(object sender, MouseEventArgs e)
        {
            if (fecha_nacimiento.Text == "" && progressBar.Value ==40 && boxnombre.Text != "" && box_email.Text != "" && box_apellidos.Text != "" &&box_telefono.Text!="")
            {
                progressBar.Value = 50;

            }

        }
    }
}
