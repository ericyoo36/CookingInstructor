#pragma checksum "..\..\..\AddIngredientPanel.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D08A0BF81BA4F77A5862543A71DC808C0D82F4EA"
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
    /// AddIngredientPanel
    /// </summary>
    public partial class AddIngredientPanel : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\AddIngredientPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchTextbox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\AddIngredientPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel listOfIngredientsStack;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\AddIngredientPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label servingSizeLabel;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\AddIngredientPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox numServingsTextbox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\AddIngredientPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveIngredient;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\AddIngredientPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseWindow;
        
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
            System.Uri resourceLocater = new System.Uri("/Vertical-Prototype;component/addingredientpanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddIngredientPanel.xaml"
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
            this.searchTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\AddIngredientPanel.xaml"
            this.searchTextbox.KeyDown += new System.Windows.Input.KeyEventHandler(this.searchTextbox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.listOfIngredientsStack = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.servingSizeLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.numServingsTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.SaveIngredient = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\AddIngredientPanel.xaml"
            this.SaveIngredient.Click += new System.Windows.RoutedEventHandler(this.SaveIngredient_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CloseWindow = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\AddIngredientPanel.xaml"
            this.CloseWindow.Click += new System.Windows.RoutedEventHandler(this.CloseWindow_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

