﻿#pragma checksum "..\..\..\..\UserControls\XmlEditorUsercontrol.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D19EBCF45CFAFB3D511DD3079950F2642A71A775"
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
using XmlEditor.UserControls;


namespace XmlEditor.UserControls {
    
    
    /// <summary>
    /// XmlEditorUsercontrol
    /// </summary>
    public partial class XmlEditorUsercontrol : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\..\UserControls\XmlEditorUsercontrol.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\UserControls\XmlEditorUsercontrol.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid EditGrid;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\UserControls\XmlEditorUsercontrol.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listbox1;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\UserControls\XmlEditorUsercontrol.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer MainViewer;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\UserControls\XmlEditorUsercontrol.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid PropertyNameGrid;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\UserControls\XmlEditorUsercontrol.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel PropertyStackPanel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/XmlEditor;component/usercontrols/xmleditorusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControls\XmlEditorUsercontrol.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.EditGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.listbox1 = ((System.Windows.Controls.ListBox)(target));
            
            #line 47 "..\..\..\..\UserControls\XmlEditorUsercontrol.xaml"
            this.listbox1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listbox1_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MainViewer = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 5:
            this.PropertyNameGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.PropertyStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

