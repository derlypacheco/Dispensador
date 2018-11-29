﻿#pragma checksum "..\..\..\Views\Search.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71E6E5A21328E56ABE8D0F44BF46E81335644E48"
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
    /// Search
    /// </summary>
    public partial class Search : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Views\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SearchingGridMain;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Views\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SearchBar;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Views\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SearchContent;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Card SearchCard;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Views\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid CardContent;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Views\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SearchTitle;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Views\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtSearchBox;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Views\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchButton;
        
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
            System.Uri resourceLocater = new System.Uri("/KMXDispenser;component/views/search.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Search.xaml"
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
            this.SearchingGridMain = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.SearchBar = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.SearchContent = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.SearchCard = ((MaterialDesignThemes.Wpf.Card)(target));
            return;
            case 5:
            this.CardContent = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.SearchTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.TxtSearchBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.SearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\Views\Search.xaml"
            this.SearchButton.Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
