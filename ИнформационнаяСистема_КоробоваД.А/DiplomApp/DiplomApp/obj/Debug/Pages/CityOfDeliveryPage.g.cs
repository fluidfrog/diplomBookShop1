﻿#pragma checksum "..\..\..\Pages\CityOfDeliveryPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "226B84A6A172D6EACA41F7B527241FA53E70EED4FB1335D00FFC001AAFCBA4EF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DiplomApp.Pages;
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


namespace DiplomApp.Pages {
    
    
    /// <summary>
    /// CityOfDeliveryPage
    /// </summary>
    public partial class CityOfDeliveryPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Pages\CityOfDeliveryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGCity;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\CityOfDeliveryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BSearchCity;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\CityOfDeliveryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BAddCity;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\CityOfDeliveryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BRedCity;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Pages\CityOfDeliveryPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BDeleteCity;
        
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
            System.Uri resourceLocater = new System.Uri("/DiplomApp;component/pages/cityofdeliverypage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\CityOfDeliveryPage.xaml"
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
            this.DGCity = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.BSearchCity = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.BAddCity = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Pages\CityOfDeliveryPage.xaml"
            this.BAddCity.Click += new System.Windows.RoutedEventHandler(this.BAddCity_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BRedCity = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Pages\CityOfDeliveryPage.xaml"
            this.BRedCity.Click += new System.Windows.RoutedEventHandler(this.BRedCity_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BDeleteCity = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Pages\CityOfDeliveryPage.xaml"
            this.BDeleteCity.Click += new System.Windows.RoutedEventHandler(this.BDeleteCity_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

