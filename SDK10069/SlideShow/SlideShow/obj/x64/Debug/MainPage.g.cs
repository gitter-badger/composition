﻿#pragma checksum "C:\Users\likuba\Desktop\internalgit\SDK10069\Samples\SlideShow\SlideShow\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A6DF310A6CC04F7EBED2388857E2ADC3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SlideShow
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
                    this.MySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element2 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 62 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element2).Click += this.AppBarButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.NearSlideCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 18 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.NearSlideCheckBox).Click += this.NearSlideCheckBox_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.FarSlideCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 24 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.FarSlideCheckBox).Click += this.FarSlideCheckBox_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.FlashlightCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 30 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.FlashlightCheckBox).Click += this.FlashlightCheckBox_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.ZoomCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 37 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.ZoomCheckBox).Click += this.ZoomCheckBox_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.StackCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 43 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.StackCheckBox).Click += this.StackCheckBox_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.PictureHost = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 53 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.PictureHost).Loaded += this.PictureHost_Loaded;
                    #line 54 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.PictureHost).SizeChanged += this.PictureHost_SizeChanged;
                    #line 55 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.PictureHost).Unloaded += this.PictureHost_Unloaded;
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

