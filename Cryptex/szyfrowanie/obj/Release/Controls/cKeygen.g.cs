﻿#pragma checksum "..\..\..\Controls\cKeygen.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C16352DD76727F5FE560AB80B971112D"
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
    /// cKeygen
    /// </summary>
    public partial class cKeygen : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Controls\cKeygen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider rotorsCount;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\Controls\cKeygen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider rotorSize;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Controls\cKeygen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider complexity;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Controls\cKeygen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox keyLength;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Controls\cKeygen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btGenerate;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Controls\cKeygen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblKey;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Controls\cKeygen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblRCount;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Controls\cKeygen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblRSize;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Controls\cKeygen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblComplex;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Controls\cKeygen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRounds;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Controls\cKeygen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btCopyKey;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Controls\cKeygen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
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
            System.Uri resourceLocater = new System.Uri("/Cryptex;component/controls/ckeygen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\cKeygen.xaml"
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
            this.rotorsCount = ((System.Windows.Controls.Slider)(target));
            
            #line 9 "..\..\..\Controls\cKeygen.xaml"
            this.rotorsCount.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.rotorsCount_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.rotorSize = ((System.Windows.Controls.Slider)(target));
            
            #line 10 "..\..\..\Controls\cKeygen.xaml"
            this.rotorSize.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.rotorSize_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.complexity = ((System.Windows.Controls.Slider)(target));
            
            #line 11 "..\..\..\Controls\cKeygen.xaml"
            this.complexity.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.complexity_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.keyLength = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\Controls\cKeygen.xaml"
            this.keyLength.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.keyLength_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btGenerate = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Controls\cKeygen.xaml"
            this.btGenerate.Click += new System.Windows.RoutedEventHandler(this.btGenerate_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblKey = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.lblRCount = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lblRSize = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lblComplex = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.txtRounds = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\Controls\cKeygen.xaml"
            this.txtRounds.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtRounds_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btCopyKey = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Controls\cKeygen.xaml"
            this.btCopyKey.Click += new System.Windows.RoutedEventHandler(this.btCopyKey_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 28 "..\..\..\Controls\cKeygen.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Label_MouseEnter_1);
            
            #line default
            #line hidden
            
            #line 28 "..\..\..\Controls\cKeygen.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Label_MouseLeave_1);
            
            #line default
            #line hidden
            return;
            case 13:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            
            #line 30 "..\..\..\Controls\cKeygen.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Label_MouseEnter_2);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\Controls\cKeygen.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Label_MouseLeave_2);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
