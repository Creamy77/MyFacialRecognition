﻿#pragma checksum "C:\Users\Solving Team\Documents\Visual Studio 2015\Projects\Facial-Recognition-Door-develop\FacialRecognitionDoor\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5DE37ED69B05260A7AD1DC56093D9B54"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FacialRecognitionDoor
{
    partial class MainPage : 
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
                    this.speechMediaElement = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                    #line 22 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MediaElement)this.speechMediaElement).Loaded += this.speechMediaElement_Loaded;
                    #line default
                }
                break;
            case 2:
                {
                    this.DisabledFeedGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.LiveFeedPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4:
                {
                    this.AnalysingVisitorGrid = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5:
                {
                    this.WelcomeBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.DetailsBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.VisitorsTitleBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.WhitelistedUsersGrid = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 49 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.WhitelistedUsersGrid).ItemClick += this.WhitelistedUsersGrid_ItemClick;
                    #line 49 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.WhitelistedUsersGrid).Loaded += this.WhitelistedUsersGrid_Loaded;
                    #line default
                }
                break;
            case 9:
                {
                    this.OxfordLoadingRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 10:
                {
                    this.WebcamFeed = (global::Windows.UI.Xaml.Controls.CaptureElement)(target);
                    #line 33 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CaptureElement)this.WebcamFeed).Loaded += this.WebcamFeed_Loaded;
                    #line default
                }
                break;
            case 11:
                {
                    this.image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 12:
                {
                    this.DisabledText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.NewUserButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 63 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.NewUserButton).Click += this.NewUserButton_Click;
                    #line default
                }
                break;
            case 14:
                {
                    this.DoorbellButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 64 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.DoorbellButton).Click += this.DoorbellButton_Click;
                    #line default
                }
                break;
            case 15:
                {
                    this.ShutdownButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 69 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.ShutdownButton).Click += this.ShutdownButton_Click;
                    #line default
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

