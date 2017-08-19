using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Trabalho1.model;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class DetalheProduto : Page
    {
        List<Produto> listaProduto = new List<Produto>();
        int produtoSelecionado;

        public DetalheProduto()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Enabled;
        }


        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {            
            listaProduto = (e.Parameter as EnvioProduto).listaProduto;
            if (e.NavigationMode != NavigationMode.Back)
                produtoSelecionado = (e.Parameter as EnvioProduto).produtoSeleciando;
            VincularDados(listaProduto[produtoSelecionado]);
            await Task.Delay(50);
            this.produtosPivot.SelectedIndex = produtoSelecionado;
           
        }
      

        private void VincularDados(Produto produto)
        {
            txtNome.Text = produto.nome;
            txtValor.Text = produto.valor.ToString();
            txtDescricao.Text = produto.descricao;

        }


        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            produtoSelecionado = this.produtosPivot.SelectedIndex;
            this.Frame.Navigate(typeof(EdicaoProduto), new EnvioProduto(listaProduto, produtoSelecionado));
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private void produtosPivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            VincularDados(listaProduto[(sender as Pivot).SelectedIndex]);            
        }
    }


}
