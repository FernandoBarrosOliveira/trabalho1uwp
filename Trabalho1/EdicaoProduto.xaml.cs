using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Trabalho1.model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace Trabalho1
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class EdicaoProduto : Page
    {
        Produto produto;
        Produto produtoOriginal = new Produto();
        int produtoSelecionado;
        int produtoSelecionadoOriginal;
        public EdicaoProduto()
        {
            this.InitializeComponent();
            //this.NavigationCacheMode = NavigationCacheMode.Enabled;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            produto = (e.Parameter as EnvioProduto).listaProduto[(e.Parameter as EnvioProduto).produtoSeleciando];
            produtoOriginal = produto;
            produtoSelecionadoOriginal = (e.Parameter as EnvioProduto).produtoSeleciando;
            VincularDados(produto);
        }

        private Boolean ValidarDados()
        {
            if(!String.IsNullOrEmpty(tboxNome.Text) &&
                !String.IsNullOrEmpty(tboxValor.Text) &&
                !String.IsNullOrEmpty(tboxDescricao.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void VincularDados(Produto produto)
        {
            txtCabecalho.Text = "Editar " + produto.nome;
            tboxNome.Text = produto.nome;
            tboxValor.Text = produto.valor.ToString();
            tboxDescricao.Text = produto.descricao;
        }

        private void SalvarDados()
        {
            produto.nome = tboxNome.Text;
            produto.valor = Convert.ToDouble(tboxValor.Text);
            produto.descricao = tboxDescricao.Text;
            produtoSelecionado = produtoSelecionadoOriginal;


        }

        private async void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            VincularDados(produtoOriginal);
            this.Frame.GoBack();
        }

        private async void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (ValidarDados())
            {
                SalvarDados();
                this.Frame.GoBack();
            }
            else
            {
                var msgDialog = new MessageDialog("Todos os dados devem ser preenchido");
                await msgDialog.ShowAsync();
            }
            
        }
    }
}
