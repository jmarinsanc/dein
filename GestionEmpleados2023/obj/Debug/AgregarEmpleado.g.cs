﻿#pragma checksum "..\..\AgregarEmpleado.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "83A078A2540C66BDCCC23E098EA2DCC9E2695E50369C7E0EDDDBCD48A33CFF35"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using GestionEmpleados2023;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace GestionEmpleados2023 {
    
    
    /// <summary>
    /// AgregarEmpleado
    /// </summary>
    public partial class AgregarEmpleado : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\AgregarEmpleado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nombreTextbox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\AgregarEmpleado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox apellidosTextbox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AgregarEmpleado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox esUsuarioCheckbox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AgregarEmpleado.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox edadTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GestionEmpleados2023;component/agregarempleado.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AgregarEmpleado.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.nombreTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.apellidosTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.esUsuarioCheckbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.edadTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 30 "..\..\AgregarEmpleado.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AgregarEmpleado_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 31 "..\..\AgregarEmpleado.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Volver_click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

