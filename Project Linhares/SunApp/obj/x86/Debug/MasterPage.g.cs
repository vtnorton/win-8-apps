﻿#pragma checksum "F:\sun\alpha\SunApp\MasterPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9EB1BB27623E9E7E06C83798DF7DB8CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SunApp
{
    partial class MasterPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.MySliptView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.stpHome = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 18 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpHome).PointerMoved += this.stpHome_PointerMoved;
                    #line 18 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpHome).PointerExited += this.stpHome_PointerExited;
                    #line 18 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpHome).Tapped += this.xtnHome_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.stpPlantation = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 37 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpPlantation).PointerMoved += this.stpPlantation_PointerMoved;
                    #line 37 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpPlantation).PointerExited += this.stpPlantation_PointerExited;
                    #line 37 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpPlantation).Tapped += this.btnPlantation_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.stpFinancial = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 56 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpFinancial).Tapped += this.btnFinancial_Click;
                    #line 56 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpFinancial).PointerMoved += this.stpFinancial_PointerMoved;
                    #line 56 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpFinancial).PointerExited += this.stpFinancial_PointerExited;
                    #line default
                }
                break;
            case 5:
                {
                    this.stpHumans = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 75 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpHumans).Tapped += this.btnHumans_Click;
                    #line 75 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpHumans).PointerMoved += this.stpHumans_PointerMoved;
                    #line 75 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpHumans).PointerExited += this.stpHumans_PointerExited;
                    #line default
                }
                break;
            case 6:
                {
                    this.stpSetting = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 94 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpSetting).Tapped += this.btnSettings_Click;
                    #line 94 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpSetting).PointerExited += this.stpSetting_PointerExited;
                    #line 94 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpSetting).PointerMoved += this.stpSetting_PointerMoved;
                    #line default
                }
                break;
            case 7:
                {
                    this.stpHelp = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 113 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpHelp).Tapped += this.btnHelp_Click;
                    #line 113 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpHelp).PointerMoved += this.stpHelp_PointerMoved;
                    #line 113 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpHelp).PointerExited += this.stpHelp_PointerExited;
                    #line default
                }
                break;
            case 8:
                {
                    this.stpAbout = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                    #line 132 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpAbout).Tapped += this.btnAbout_Click;
                    #line 132 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpAbout).PointerMoved += this.stpAbout_PointerMoved;
                    #line 132 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.StackPanel)this.stpAbout).PointerExited += this.stpAbout_PointerExited;
                    #line default
                }
                break;
            case 9:
                {
                    this.gridAbout = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 10:
                {
                    this.btnAbout = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 11:
                {
                    this.txtAbout = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.gridHelp = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 13:
                {
                    this.btnHelp = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 14:
                {
                    this.txtHelp = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.gridSettings = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 16:
                {
                    this.btnSettings = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 17:
                {
                    this.txtSettings = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18:
                {
                    this.gridHumans = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 19:
                {
                    this.btnHumans = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 20:
                {
                    this.txtHumans = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 21:
                {
                    this.gridFinancial = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 22:
                {
                    this.btnFinancial = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 23:
                {
                    this.txtFinancial = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 24:
                {
                    this.gridPlantation = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 25:
                {
                    this.btnPlantation = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 26:
                {
                    this.txtPlantation = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 27:
                {
                    this.gridHome = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 28:
                {
                    this.btnHome = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                }
                break;
            case 29:
                {
                    this.txtHome = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 30:
                {
                    this.btnMenu = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\MasterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnMenu).Click += this.btnMenu_Click;
                    #line default
                }
                break;
            case 31:
                {
                    this.frameBody = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
