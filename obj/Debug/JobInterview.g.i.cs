﻿#pragma checksum "..\..\JobInterview.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45F19B3A2942D8B54019945368B1B6ED849768A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using FutureHR;
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


namespace FutureHR {
    
    
    /// <summary>
    /// JobInterview
    /// </summary>
    public partial class JobInterview : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\JobInterview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button returnBtn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\JobInterview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel powrot;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\JobInterview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button homeBtn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\JobInterview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel home;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\JobInterview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock odpowiedzi;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\JobInterview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel ikona;
        
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
            System.Uri resourceLocater = new System.Uri("/FutureHR;component/jobinterview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\JobInterview.xaml"
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
            this.returnBtn = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\JobInterview.xaml"
            this.returnBtn.Click += new System.Windows.RoutedEventHandler(this.ReturnClicked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.powrot = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 3:
            this.homeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\JobInterview.xaml"
            this.homeBtn.Click += new System.Windows.RoutedEventHandler(this.HomeClicked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.home = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 5:
            
            #line 44 "..\..\JobInterview.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NameClicked);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 45 "..\..\JobInterview.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AgeClicked);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 46 "..\..\JobInterview.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FeaturesClicked);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 47 "..\..\JobInterview.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.HelloClicked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.odpowiedzi = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.ikona = ((System.Windows.Controls.WrapPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

