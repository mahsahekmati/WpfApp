﻿#pragma checksum "..\..\..\window\win_main.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A2B1F196BDEC972E2ACE8F3287E4611611C0661E02952833D4CD011C865390FF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Arash.PersianDateControls;
using Microsoft.Windows.Controls;
using Microsoft.Windows.Controls.Ribbon;
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
using anbardari.window;


namespace anbardari.window {
    
    
    /// <summary>
    /// win_main
    /// </summary>
    public partial class win_main : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\window\win_main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.Ribbon.RibbonApplicationSplitMenuItem system_part;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\window\win_main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.Ribbon.RibbonButton createfactor;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\window\win_main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_name;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\window\win_main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_family;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\window\win_main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_time;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\window\win_main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Arash.PersianDateControls.PersianDatePicker tarikh;
        
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
            System.Uri resourceLocater = new System.Uri("/anbardari;component/window/win_main.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\window\win_main.xaml"
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
            
            #line 9 "..\..\..\window\win_main.xaml"
            ((anbardari.window.win_main)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\window\win_main.xaml"
            ((anbardari.window.win_main)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 19 "..\..\..\window\win_main.xaml"
            ((Microsoft.Windows.Controls.Ribbon.RibbonSplitMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_exit_click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 27 "..\..\..\window\win_main.xaml"
            ((Microsoft.Windows.Controls.Ribbon.RibbonApplicationSplitMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_windows_user);
            
            #line default
            #line hidden
            return;
            case 4:
            this.system_part = ((Microsoft.Windows.Controls.Ribbon.RibbonApplicationSplitMenuItem)(target));
            
            #line 29 "..\..\..\window\win_main.xaml"
            this.system_part.Click += new System.Windows.RoutedEventHandler(this.system_part_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 31 "..\..\..\window\win_main.xaml"
            ((Microsoft.Windows.Controls.Ribbon.RibbonApplicationSplitMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.RibbonApplicationSplitMenuItem_Click_1);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 32 "..\..\..\window\win_main.xaml"
            ((Microsoft.Windows.Controls.Ribbon.RibbonApplicationSplitMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.RibbonApplicationSplitMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 39 "..\..\..\window\win_main.xaml"
            ((Microsoft.Windows.Controls.Ribbon.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.showproduct_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.createfactor = ((Microsoft.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 54 "..\..\..\window\win_main.xaml"
            this.createfactor.Click += new System.Windows.RoutedEventHandler(this.createfactor_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lbl_name = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.lbl_family = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.lbl_time = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.tarikh = ((Arash.PersianDateControls.PersianDatePicker)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

