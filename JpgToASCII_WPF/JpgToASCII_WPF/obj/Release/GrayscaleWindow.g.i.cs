﻿#pragma checksum "..\..\GrayscaleWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ECFC174A20358CE9E3B49F0FBCD9B29D0B0F30E71250A0DB50297DB4AF8E44F4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using JpgToASCII_WPF;
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


namespace JpgToASCII_WPF {
    
    
    /// <summary>
    /// GrayscaleWindow
    /// </summary>
    public partial class GrayscaleWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\GrayscaleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal JpgToASCII_WPF.GrayscaleWindow grayScaleWindow;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\GrayscaleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image grayscaleImage;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\GrayscaleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConvertButton;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\GrayscaleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConvertASCIIButton;
        
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
            System.Uri resourceLocater = new System.Uri("/JpgToASCII_WPF;component/grayscalewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GrayscaleWindow.xaml"
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
            this.grayScaleWindow = ((JpgToASCII_WPF.GrayscaleWindow)(target));
            
            #line 11 "..\..\GrayscaleWindow.xaml"
            this.grayScaleWindow.SizeChanged += new System.Windows.SizeChangedEventHandler(this.grayScaleWindow_SizeChanged);
            
            #line default
            #line hidden
            
            #line 11 "..\..\GrayscaleWindow.xaml"
            this.grayScaleWindow.Closing += new System.ComponentModel.CancelEventHandler(this.grayScaleWindow_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 38 "..\..\GrayscaleWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Close_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 46 "..\..\GrayscaleWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_SaveASCII_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 48 "..\..\GrayscaleWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_SaveGrayscale_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.grayscaleImage = ((System.Windows.Controls.Image)(target));
            
            #line 55 "..\..\GrayscaleWindow.xaml"
            this.grayscaleImage.Loaded += new System.Windows.RoutedEventHandler(this.grayscaleImage_Loaded);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ConvertButton = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\GrayscaleWindow.xaml"
            this.ConvertButton.Click += new System.Windows.RoutedEventHandler(this.ConvertGrayscaleButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ConvertASCIIButton = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\GrayscaleWindow.xaml"
            this.ConvertASCIIButton.Click += new System.Windows.RoutedEventHandler(this.ConvertASCIIButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

