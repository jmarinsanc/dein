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
    }
}
