﻿#pragma checksum "..\..\..\Pages\AddOrRedactPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E2651A57CD3BF98CB7FBDCC72FD45A1D3146D0A3E7F3118958C79D98D596BC95"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using HardwareStore.Pages;
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


namespace HardwareStore.Pages {
    
    
    /// <summary>
    /// AddOrRedactPage
    /// </summary>
    public partial class AddOrRedactPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Pages\AddOrRedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TitleTB;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\AddOrRedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DescriptionTB;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\AddOrRedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CostTB;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Pages\AddOrRedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DiscountTB;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\AddOrRedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ProductImg;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\AddOrRedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeImgBtn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Pages\AddOrRedactPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveChangesBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/HardwareStore;component/pages/addorredactpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AddOrRedactPage.xaml"
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
            this.TitleTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.DescriptionTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.CostTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.DiscountTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.ProductImg = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.ChangeImgBtn = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Pages\AddOrRedactPage.xaml"
            this.ChangeImgBtn.Click += new System.Windows.RoutedEventHandler(this.ChangeImgBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SaveChangesBtn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Pages\AddOrRedactPage.xaml"
            this.SaveChangesBtn.Click += new System.Windows.RoutedEventHandler(this.SaveChangesBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

