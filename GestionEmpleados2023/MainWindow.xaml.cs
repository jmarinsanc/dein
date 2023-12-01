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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestionEmpleados2023
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ir_ListaEmpleados(object sender, RoutedEventArgs e)
        {
            ListaEmpleados lista = new ListaEmpleados();
            this.Close();
            lista.Show();
        }

        private void Ir_AgregarEmpleado(object sender, RoutedEventArgs e)
        {
            AgregarEmpleado agregar = new AgregarEmpleado();
            this.Close();
            agregar.Show();
        }

        private void Ir_Buscar(object sender, RoutedEventArgs e)
        {
            BuscarEmpleado buscar = new BuscarEmpleado();
            this.Close();
            buscar.Show();
        }
    }
}
