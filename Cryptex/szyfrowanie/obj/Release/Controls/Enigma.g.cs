﻿#pragma checksum "..\..\..\Controls\Enigma.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "53CD9CACAF6D65D5DC72F04E0A341555"
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
    /// Enigma
    /// </summary>
    public partial class Enigma : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Controls\Enigma.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Enigma_btOpis;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\Controls\Enigma.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Enigma_btAlgo;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Controls\Enigma.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Enigma_btDo;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Controls\Enigma.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cezar_btPom;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Controls\Enigma.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Enigma_Grid;
        
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
            System.Uri resourceLocater = new System.Uri("/Cryptex;component/controls/enigma.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\Enigma.xaml"
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
            this.Enigma_btOpis = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\..\Controls\Enigma.xaml"
            this.Enigma_btOpis.Click += new System.Windows.RoutedEventHandler(this.Enigma_btOpis_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Enigma_btAlgo = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\Controls\Enigma.xaml"
            this.Enigma_btAlgo.Click += new System.Windows.RoutedEventHandler(this.Enigma_btAlgo_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Enigma_btDo = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\Controls\Enigma.xaml"
            this.Enigma_btDo.Click += new System.Windows.RoutedEventHandler(this.Enigma_btDo_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Cezar_btPom = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Controls\Enigma.xaml"
            this.Cezar_btPom.Click += new System.Windows.RoutedEventHandler(this.Cezar_btPom_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Enigma_Grid = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

