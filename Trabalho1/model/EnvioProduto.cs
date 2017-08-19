using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1.model
{
    class EnvioProduto
    {
        public int produtoSeleciando;
        public List<Produto> listaProduto;
        
        public EnvioProduto(List<Produto> listaProduto, int produtoSelecionado)
        {
            this.produtoSeleciando = produtoSelecionado;
            this.listaProduto = listaProduto;
        }

    }




}
