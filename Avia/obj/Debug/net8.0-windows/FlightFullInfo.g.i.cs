// Updated by XamlIntelliSenseFileGenerator 17.06.2024 1:31:34
#pragma checksum "..\..\..\FlightFullInfo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08D4490EBDE5F422FF61E557E02368BA866D7F08"
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
    /// FlightFullInfo
    /// </summary>
    public partial class FlightFullInfo : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 10 "..\..\..\FlightFullInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label airlinesLabel;

#line default
#line hidden


#line 11 "..\..\..\FlightFullInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label originLabel;

#line default
#line hidden


#line 12 "..\..\..\FlightFullInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label destinationLabel;

#line default
#line hidden


#line 13 "..\..\..\FlightFullInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label departureTimeLable;

#line default
#line hidden


#line 14 "..\..\..\FlightFullInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label arrivalTimeLabel;

#line default
#line hidden


#line 15 "..\..\..\FlightFullInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label countOfFreeSeatsLabel;

#line default
#line hidden


#line 16 "..\..\..\FlightFullInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bookBtn;

#line default
#line hidden


#line 17 "..\..\..\FlightFullInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button favoriteBtn;

#line default
#line hidden


#line 18 "..\..\..\FlightFullInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label statusLabel;

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
            System.Uri resourceLocater = new System.Uri("/Avia;component/flightfullinfo.xaml", System.UriKind.Relative);

#line 1 "..\..\..\FlightFullInfo.xaml"
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

#line 8 "..\..\..\FlightFullInfo.xaml"
                    ((Avia.FlightFullInfo)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);

#line default
#line hidden
                    return;
                case 2:
                    this.airlinesLabel = ((System.Windows.Controls.Label)(target));
                    return;
                case 3:
                    this.originLabel = ((System.Windows.Controls.Label)(target));
                    return;
                case 4:
                    this.destinationLabel = ((System.Windows.Controls.Label)(target));
                    return;
                case 5:
                    this.departureTimeLable = ((System.Windows.Controls.Label)(target));
                    return;
                case 6:
                    this.arrivalTimeLabel = ((System.Windows.Controls.Label)(target));
                    return;
                case 7:
                    this.countOfFreeSeatsLabel = ((System.Windows.Controls.Label)(target));
                    return;
                case 8:
                    this.bookBtn = ((System.Windows.Controls.Button)(target));
                    return;
                case 9:
                    this.favoriteBtn = ((System.Windows.Controls.Button)(target));

#line 17 "..\..\..\FlightFullInfo.xaml"
                    this.favoriteBtn.Click += new System.Windows.RoutedEventHandler(this.favoriteBtn_Click);

#line default
#line hidden
                    return;
                case 10:
                    this.statusLabel = ((System.Windows.Controls.Label)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button backBtn;
    }
}

