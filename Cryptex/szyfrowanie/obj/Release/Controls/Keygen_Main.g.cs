﻿#pragma checksum "..\..\..\Controls\Keygen_Main.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "26EB7AC12E9D56EF61F6B814D8DAD1B8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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


namespace Szyfrowanie.Controls {
    
    
    /// <summary>
    /// Keygen_Main
    /// </summary>
    public partial class Keygen_Main : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Controls\Keygen_Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Keygen_btOpis;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\Controls\Keygen_Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Keygen_btDo;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Controls\Keygen_Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Keygen_btPom;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Controls\Keygen_Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Keygen_Grid;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Controls\Keygen_Main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Keygen_btAlgo;
        
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
            System.Uri resourceLocater = new System.Uri("/Cryptex;component/controls/keygen_main.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\Keygen_Main.xaml"
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
            this.Keygen_btOpis = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\..\Controls\Keygen_Main.xaml"
            this.Keygen_btOpis.Click += new System.Windows.RoutedEventHandler(this.Keygen_btOpis_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Keygen_btDo = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\Controls\Keygen_Main.xaml"
            this.Keygen_btDo.Click += new System.Windows.RoutedEventHandler(this.Keygen_btDo_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Keygen_btPom = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\Controls\Keygen_Main.xaml"
            this.Keygen_btPom.Click += new System.Windows.RoutedEventHandler(this.Keygen_btPom_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Keygen_Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.Keygen_btAlgo = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Controls\Keygen_Main.xaml"
            this.Keygen_btAlgo.Click += new System.Windows.RoutedEventHandler(this.Keygen_btAlgo_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

