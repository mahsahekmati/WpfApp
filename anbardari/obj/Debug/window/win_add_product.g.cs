﻿#pragma checksum "..\..\..\window\win_add_product.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "31BA99E2C0E91473C92BF27AEEA4E125506840251CD58E3BA5ED9F3AFBB9DCC8"
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
    /// win_add_product
    /// </summary>
    public partial class win_add_product : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\window\win_add_product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_product_name;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\window\win_add_product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_productdesc;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\window\win_add_product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_create_product;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\window\win_add_product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_exit;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\window\win_add_product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image productimage;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\window\win_add_product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_username;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\window\win_add_product.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_date;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\window\win_add_product.xaml"
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
            System.Uri resourceLocater = new System.Uri("/anbardari;component/window/win_add_product.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\window\win_add_product.xaml"
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
            
            #line 9 "..\..\..\window\win_add_product.xaml"
            ((anbardari.window.win_add_product)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txt_product_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txt_productdesc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btn_create_product = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\window\win_add_product.xaml"
            this.btn_create_product.Click += new System.Windows.RoutedEventHandler(this.btn_create_product_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_exit = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\window\win_add_product.xaml"
            this.btn_exit.Click += new System.Windows.RoutedEventHandler(this.btn_exit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.productimage = ((System.Windows.Controls.Image)(target));
            
            #line 73 "..\..\..\window\win_add_product.xaml"
            this.productimage.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.productimage_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lbl_username = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lbl_date = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.tarikh = ((Arash.PersianDateControls.PersianDatePicker)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

