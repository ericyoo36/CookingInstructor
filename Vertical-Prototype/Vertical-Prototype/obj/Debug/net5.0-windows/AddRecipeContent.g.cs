#pragma checksum "..\..\..\AddRecipeContent.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DD35F05FC00F48BE8BA882212FB7AD08BBD621C0"
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
    /// AddRecipeContent
    /// </summary>
    public partial class AddRecipeContent : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\AddRecipeContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addRecipeContent_addPhotoButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\AddRecipeContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image _recipePhoto;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\AddRecipeContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveRecipe;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\AddRecipeContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image _saveButtonImage;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\AddRecipeContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox addRecipeContent_difficultyCombo;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\AddRecipeContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel IngredientsPanel;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\AddRecipeContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addRecipeContent_addIngredientButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\AddRecipeContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox addRecipeContent_prepTimeCombo;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\AddRecipeContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InstructionsTextbox;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\AddRecipeContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel AddIngredientStack;
        
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
            System.Uri resourceLocater = new System.Uri("/Vertical-Prototype;component/addrecipecontent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddRecipeContent.xaml"
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
            this.addRecipeContent_addPhotoButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\AddRecipeContent.xaml"
            this.addRecipeContent_addPhotoButton.Click += new System.Windows.RoutedEventHandler(this.addRecipeContent_addPhotoButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this._recipePhoto = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.SaveRecipe = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\AddRecipeContent.xaml"
            this.SaveRecipe.Click += new System.Windows.RoutedEventHandler(this.SaveRecipeButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this._saveButtonImage = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.addRecipeContent_difficultyCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.IngredientsPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.addRecipeContent_addIngredientButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\AddRecipeContent.xaml"
            this.addRecipeContent_addIngredientButton.Click += new System.Windows.RoutedEventHandler(this.addRecipeContent_addIngredientButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.addRecipeContent_prepTimeCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.InstructionsTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.AddIngredientStack = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

