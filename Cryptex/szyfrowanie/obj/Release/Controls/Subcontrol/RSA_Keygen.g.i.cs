﻿#pragma checksum "..\..\..\..\Controls\Subcontrol\RSA_Keygen.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6696FC34129F6923ED4F672B6448886F"
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


namespace Szyfrowanie.Controls.Subcontrol {
    
    
    /// <summary>
    /// RSA_Keygen
    /// </summary>
    public partial class RSA_Keygen : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\Controls\Subcontrol\RSA_Keygen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Keyn;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Controls\Subcontrol\RSA_Keygen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Keye;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Controls\Subcontrol\RSA_Keygen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Keynn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Controls\Subcontrol\RSA_Keygen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Keyd;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Controls\Subcontrol\RSA_Keygen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_Gen;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Controls\Subcontrol\RSA_Keygen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Range;
        
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
            System.Uri resourceLocater = new System.Uri("/Cryptex;component/controls/subcontrol/rsa_keygen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Controls\Subcontrol\RSA_Keygen.xaml"
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
            this.txt_Keyn = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txt_Keye = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txt_Keynn = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_Keyd = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.bt_Gen = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\Controls\Subcontrol\RSA_Keygen.xaml"
            this.bt_Gen.Click += new System.Windows.RoutedEventHandler(this.bt_Gen_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txt_Range = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

