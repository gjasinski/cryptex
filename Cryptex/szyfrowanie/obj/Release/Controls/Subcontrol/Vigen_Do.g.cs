﻿#pragma checksum "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "53A9887F19EF37328C861F289A4C9C47"
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


namespace Szyfrowanie.Controls.Subcontrol {
    
    
    /// <summary>
    /// Vigen_Do
    /// </summary>
    public partial class Vigen_Do : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPlain;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtKey;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCiphered;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCryptex;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtKeyDC;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDeciphered;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button2;
        
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
            System.Uri resourceLocater = new System.Uri("/Cryptex;component/controls/subcontrol/vigen_do.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
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
            this.txtPlain = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
            this.txtPlain.GotFocus += new System.Windows.RoutedEventHandler(this.txtPlain_GotFocus);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtKey = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
            this.txtKey.GotFocus += new System.Windows.RoutedEventHandler(this.txtKey_GotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtCiphered = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            
            #line 14 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtCryptex = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
            this.txtCryptex.GotFocus += new System.Windows.RoutedEventHandler(this.txtCryptex_GotFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtKeyDC = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
            this.txtKeyDC.GotFocus += new System.Windows.RoutedEventHandler(this.txtKeyDC_GotFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtDeciphered = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Button2 = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
            this.Button2.Click += new System.Windows.RoutedEventHandler(this.Button2_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 21 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Label_MouseEnter_1);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Label_MouseLeave_1);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 22 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Label_MouseEnter_2);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Label_MouseLeave_2);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 23 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Label_MouseEnter_3);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Label_MouseLeave_3);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 24 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Label_MouseEnter_4);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\..\Controls\Subcontrol\Vigen_Do.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Label_MouseLeave_4);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

