﻿#pragma checksum "..\..\..\Views\Dashboard.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10836921582EEBAEF9117A3AE687671DA061E0FE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using KMXDispenser.Views;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace KMXDispenser.Views {
    
    
    /// <summary>
    /// Dashboard
    /// </summary>
    public partial class Dashboard : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid DashboardGridMain;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid DashboardGridModules;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddModulesButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ModulesTitle;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ManualsButton;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ManualsTitle;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConfigButton;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ConfigTitle;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Views\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrameContent;
        
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
            System.Uri resourceLocater = new System.Uri("/KMXDispenser;component/views/dashboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Dashboard.xaml"
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
            this.DashboardGridMain = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.DashboardGridModules = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.AddModulesButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Views\Dashboard.xaml"
            this.AddModulesButton.Click += new System.Windows.RoutedEventHandler(this.AddModulesButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ModulesTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.ManualsButton = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Views\Dashboard.xaml"
            this.ManualsButton.Click += new System.Windows.RoutedEventHandler(this.ManualsButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ManualsTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.ConfigButton = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.ConfigTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.FrameContent = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

