﻿#pragma checksum "..\..\..\RecipeDisplayContent.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4C2068BB26EE8FEFC839F65B083AB00F0124CAFF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using Vertical_Prototype;


namespace Vertical_Prototype {
    
    
    /// <summary>
    /// RecipeDisplayContent
    /// </summary>
    public partial class RecipeDisplayContent : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\RecipeDisplayContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label _prepTimeLabel;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\RecipeDisplayContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button recipeDisplayContent_favoriteButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\RecipeDisplayContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image _favoriteImage;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\RecipeDisplayContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel IngredientsPanel;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\RecipeDisplayContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button recipeDisplayContent_rateButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Vertical-Prototype;component/recipedisplaycontent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RecipeDisplayContent.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this._prepTimeLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.recipeDisplayContent_favoriteButton = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this._favoriteImage = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.IngredientsPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.recipeDisplayContent_rateButton = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\RecipeDisplayContent.xaml"
            this.recipeDisplayContent_rateButton.Click += new System.Windows.RoutedEventHandler(this.recipeDisplayContent_rateButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

