﻿#pragma checksum "C:\Users\Fernando-DellWin10\source\repos\Trabalho1\Trabalho1\EdicaoProduto.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DC9772E5DC4C66061FBD62E26C8CEC81"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trabalho1
{
    partial class EdicaoProduto : 
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
                    this.txtCabecalho = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.tboxNome = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.tboxValor = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    this.tboxDescricao = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    this.btnCancelar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\EdicaoProduto.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCancelar).Click += this.btnCancelar_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.btnSalvar = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 24 "..\..\..\EdicaoProduto.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSalvar).Click += this.btnSalvar_Click;
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

