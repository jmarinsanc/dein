﻿using System;
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

namespace Orla_de_Juan_Pablo_Marin
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Profile : Window
    {
        public Profile(String Nombre, String Apellidos, String Email, String
        Foto)
        {
            InitializeComponent();
            Profile_Nombre.Text = Nombre;
            Profile_Apellidos.Text = Apellidos;
            Profile_Email.Text = Email;
            Profile_Image.Source = new BitmapImage(new Uri(string.Format(@"..\..\{0}", Foto), UriKind.Relative));
        }
    }
}
