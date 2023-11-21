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
    /// Lógica de interacción para footer.xaml
    /// </summary>
    public partial class footer : UserControl
    {
        public footer()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {

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
    }
}
