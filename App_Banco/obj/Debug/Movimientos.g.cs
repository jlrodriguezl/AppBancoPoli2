﻿#pragma checksum "..\..\Movimientos.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BEC95E030B2F5D5F6A85FCC1660F14F3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace App_Banco {
    
    
    /// <summary>
    /// Movimientos
    /// </summary>
    public partial class Movimientos : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\Movimientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt_title;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Movimientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Buscar_XFecha;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Movimientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_Log;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Movimientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_Cant_Regist;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Movimientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_Cant_Regist_Validos;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Movimientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_Cant_Regist_Erróneos;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Movimientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Exportar_Excel;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Movimientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_fecha_inicial;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Movimientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_fecha_final;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Movimientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Volver;
        
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
            System.Uri resourceLocater = new System.Uri("/App_Banco;component/movimientos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Movimientos.xaml"
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
            this.txt_title = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.btn_Buscar_XFecha = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Movimientos.xaml"
            this.btn_Buscar_XFecha.Click += new System.Windows.RoutedEventHandler(this.btn_Cargar_Clientes_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lbl_Log = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lbl_Cant_Regist = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lbl_Cant_Regist_Validos = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lbl_Cant_Regist_Erróneos = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.btn_Exportar_Excel = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Movimientos.xaml"
            this.btn_Exportar_Excel.Click += new System.Windows.RoutedEventHandler(this.btn_Cargar_Clientes_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lbl_fecha_inicial = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lbl_fecha_final = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.btn_Volver = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\Movimientos.xaml"
            this.btn_Volver.Click += new System.Windows.RoutedEventHandler(this.btn_Cargar_Clientes_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

