﻿#pragma checksum "..\..\..\View\Authorise.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "997E91656BC1F6ECCF234AC3389A7760C2D5869E7DF031899B47CD4F388BE452"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using bookwormsWpf.View;


namespace bookwormsWpf.View {
    
    
    /// <summary>
    /// Authorise
    /// </summary>
    public partial class Authorise : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\View\Authorise.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button fromAuthorisetoMain;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\View\Authorise.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginTextbox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\View\Authorise.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordPb;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\View\Authorise.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loginButton;
        
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
            System.Uri resourceLocater = new System.Uri("/bookwormsWpf;component/view/authorise.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Authorise.xaml"
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
            this.fromAuthorisetoMain = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\View\Authorise.xaml"
            this.fromAuthorisetoMain.Click += new System.Windows.RoutedEventHandler(this.fromAuthorisetoMain_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.loginTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\View\Authorise.xaml"
            this.loginTextbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.loginTextbox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.passwordPb = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 50 "..\..\..\View\Authorise.xaml"
            this.passwordPb.PasswordChanged += new System.Windows.RoutedEventHandler(this.passwordPb_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.loginButton = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\View\Authorise.xaml"
            this.loginButton.Click += new System.Windows.RoutedEventHandler(this.loginButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

