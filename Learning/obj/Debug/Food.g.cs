﻿#pragma checksum "..\..\Food.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7BF27FC4A2C166FAB7E5BAA18E4B07C7"
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


namespace Learning {
    
    
    /// <summary>
    /// Food
    /// </summary>
    public partial class Food : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\Food.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgQuestiion;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\Food.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAnswer;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\Food.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOK;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\Food.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnclose;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Food.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblScore;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Food.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblanswer;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Food.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas cvsbegin;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Food.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnbegin;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Food.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblQuestion;
        
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
            System.Uri resourceLocater = new System.Uri("/Learning;component/food.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Food.xaml"
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
            this.imgQuestiion = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.txtAnswer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnOK = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\Food.xaml"
            this.btnOK.Click += new System.Windows.RoutedEventHandler(this.btnOK_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnclose = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Food.xaml"
            this.btnclose.Click += new System.Windows.RoutedEventHandler(this.btnclose_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lblScore = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lblanswer = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.cvsbegin = ((System.Windows.Controls.Canvas)(target));
            return;
            case 8:
            this.btnbegin = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Food.xaml"
            this.btnbegin.Click += new System.Windows.RoutedEventHandler(this.btnbegin_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lblQuestion = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

