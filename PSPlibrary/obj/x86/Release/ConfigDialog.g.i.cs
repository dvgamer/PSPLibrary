﻿#pragma checksum "..\..\..\ConfigDialog.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "89EE4AAAE17992E58E9A9A769217F8C7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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
using System.Windows.Forms.Integration;
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


namespace PSPlibrary {
    
    
    /// <summary>
    /// ConfigDialog
    /// </summary>
    public partial class ConfigDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\ConfigDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\..\ConfigDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonBrowse;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\ConfigDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBrowse;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\ConfigDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border border1;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\ConfigDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonApply;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\ConfigDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/PSPlibrary;component/configdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ConfigDialog.xaml"
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
            
            #line 4 "..\..\..\ConfigDialog.xaml"
            ((PSPlibrary.ConfigDialog)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.ButtonBrowse = ((System.Windows.Controls.Button)(target));
            
            #line 7 "..\..\..\ConfigDialog.xaml"
            this.ButtonBrowse.Click += new System.Windows.RoutedEventHandler(this.ButtonBrowse_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtBrowse = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.border1 = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            this.ButtonApply = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\ConfigDialog.xaml"
            this.ButtonApply.Click += new System.Windows.RoutedEventHandler(this.ButtonApply_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonCancel = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\ConfigDialog.xaml"
            this.ButtonCancel.Click += new System.Windows.RoutedEventHandler(this.ButtonCanceled_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

