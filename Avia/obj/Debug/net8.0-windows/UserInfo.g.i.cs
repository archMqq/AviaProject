// Updated by XamlIntelliSenseFileGenerator 17.06.2024 0:46:21
#pragma checksum "..\..\..\UserInfo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C6DD41A33F14A5083DD3DA2D5F9C8B78DA585110"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Avia;
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


namespace Avia
{


    /// <summary>
    /// UserInfo
    /// </summary>
    public partial class UserInfo : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 11 "..\..\..\UserInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameBox;

#line default
#line hidden


#line 14 "..\..\..\UserInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox surnameBox;

#line default
#line hidden


#line 17 "..\..\..\UserInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox patronymicBox;

#line default
#line hidden


#line 20 "..\..\..\UserInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passportSeriesBox;

#line default
#line hidden


#line 23 "..\..\..\UserInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passportNumberBox;

#line default
#line hidden


#line 24 "..\..\..\UserInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button changeBtn;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Avia;component/userinfo.xaml", System.UriKind.Relative);

#line 1 "..\..\..\UserInfo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.nameBox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 2:
                    this.surnameBox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.patronymicBox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.passportSeriesBox = ((System.Windows.Controls.TextBox)(target));

#line 20 "..\..\..\UserInfo.xaml"
                    this.passportSeriesBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInputIsNumeric);

#line default
#line hidden
                    return;
                case 5:
                    this.passportNumberBox = ((System.Windows.Controls.TextBox)(target));

#line 23 "..\..\..\UserInfo.xaml"
                    this.passportNumberBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInputIsNumeric);

#line default
#line hidden
                    return;
                case 6:
                    this.changeBtn = ((System.Windows.Controls.Button)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button backBtn;
    }
}

