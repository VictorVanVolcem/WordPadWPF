﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CEC4AAE48C6F271029C139EBC03FA264FD7C8CA9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NotePad.wpf;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace NotePad.wpf {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal NotePad.wpf.MainWindow wndMainWindow;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition rowFooter;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuOpen;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuSave;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuSaveAs;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuExit;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuStatusBar;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem mnuWordWrap;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtWordpad;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblLineCount;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblColumnCount;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NotePad.wpf;V1.0.0.0;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.wndMainWindow = ((NotePad.wpf.MainWindow)(target));
            
            #line 9 "..\..\..\MainWindow.xaml"
            this.wndMainWindow.Closing += new System.ComponentModel.CancelEventHandler(this.wndMainWindow_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.rowFooter = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 3:
            this.mnuOpen = ((System.Windows.Controls.MenuItem)(target));
            
            #line 27 "..\..\..\MainWindow.xaml"
            this.mnuOpen.Click += new System.Windows.RoutedEventHandler(this.mnuOpen_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.mnuSave = ((System.Windows.Controls.MenuItem)(target));
            
            #line 28 "..\..\..\MainWindow.xaml"
            this.mnuSave.Click += new System.Windows.RoutedEventHandler(this.mnuSave_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.mnuSaveAs = ((System.Windows.Controls.MenuItem)(target));
            
            #line 29 "..\..\..\MainWindow.xaml"
            this.mnuSaveAs.Click += new System.Windows.RoutedEventHandler(this.mnuSaveAs_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.mnuExit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 34 "..\..\..\MainWindow.xaml"
            this.mnuExit.Click += new System.Windows.RoutedEventHandler(this.MnuExit_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.mnuStatusBar = ((System.Windows.Controls.MenuItem)(target));
            
            #line 63 "..\..\..\MainWindow.xaml"
            this.mnuStatusBar.Click += new System.Windows.RoutedEventHandler(this.MnuStatusBar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.mnuWordWrap = ((System.Windows.Controls.MenuItem)(target));
            
            #line 64 "..\..\..\MainWindow.xaml"
            this.mnuWordWrap.Click += new System.Windows.RoutedEventHandler(this.MnuWordWrap_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtWordpad = ((System.Windows.Controls.TextBox)(target));
            
            #line 73 "..\..\..\MainWindow.xaml"
            this.txtWordpad.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtWordpad_KeyUp);
            
            #line default
            #line hidden
            
            #line 73 "..\..\..\MainWindow.xaml"
            this.txtWordpad.MouseMove += new System.Windows.Input.MouseEventHandler(this.txtWordpad_MouseMove);
            
            #line default
            #line hidden
            
            #line 73 "..\..\..\MainWindow.xaml"
            this.txtWordpad.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtWordpad_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.lblLineCount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.lblColumnCount = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

