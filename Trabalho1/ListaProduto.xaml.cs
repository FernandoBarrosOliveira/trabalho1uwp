using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public sealed partial class ListaProduto : Page
    {
        List<Produto> listaProduto = new List<Produto>();
        int produtoSelecionado;

        
        public ListaProduto()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Enabled;
            this.AlimentaListaProduto();
            this.VinculaProdutoNosComponentes();


        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            VinculaProdutoNosComponentes();

        }

        private void AlimentaListaProduto()
        {
            listaProduto.Add(new Produto());
            listaProduto.Add(new Produto());
            listaProduto.Add(new Produto());
            listaProduto.Add(new Produto());
            listaProduto.Add(new Produto());
            listaProduto.Add(new Produto());

            listaProduto[0].nome = "Skol";
            listaProduto[0].valor = 5.00;
            listaProduto[0].descricao = "Cerveja que desce redondo";
            listaProduto[0].imagem = null;

            listaProduto[1].nome = "Brahma";
            listaProduto[1].valor = 4.00;
            listaProduto[1].descricao = "A numero 1";
            listaProduto[1].imagem = null;

            listaProduto[2].nome = "Kaiser";
            listaProduto[2].valor = 5.00;
            listaProduto[2].descricao = "Nota 10";
            listaProduto[2].imagem = null;

            listaProduto[3].nome = "Antartica";
            listaProduto[3].valor = 5.00;
            listaProduto[3].descricao = "A mais gostosa";
            listaProduto[3].imagem = null;

            listaProduto[4].nome = "Itaipava";
            listaProduto[4].valor = 5.00;
            listaProduto[4].descricao = "Cerveja da verão";
            listaProduto[4].imagem = null;

            listaProduto[5].nome = "Heineken";
            listaProduto[5].valor = 5.00;
            listaProduto[5].descricao = "Cerveja de verdae";
            listaProduto[5].imagem = null;
        }

        public void VinculaProdutoNosComponentes()
        {
           
            hbtnProduto0.Content = listaProduto[0].nome;
            hbtnProduto1.Content = listaProduto[1].nome;
            hbtnProduto2.Content = listaProduto[2].nome;
            hbtnProduto3.Content = listaProduto[3].nome;
            hbtnProduto4.Content = listaProduto[4].nome;
            hbtnProduto5.Content = listaProduto[5].nome;

        }

        public async void LerDescricaoProduto(string text)
        {
            MediaElement media = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync(text);
            media.SetSource(stream, stream.ContentType);
            media.Play();
        }

        private void BtnProduto_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < listaProduto.Count; i++)
            {
                if ((sender as HyperlinkButton).Name.Equals("hbtnProduto" + i))
                {
                    produtoSelecionado = i;
                    this.Frame.Navigate(typeof(DetalheProduto), new EnvioProduto(listaProduto, produtoSelecionado));
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i =0; i < listaProduto.Count; i++)
            {
                if ((sender as Button).Name.Equals("btnImage" + i))
                {
                    LerDescricaoProduto(listaProduto[i].nome);
                }
            }                        
        }
    }
}
