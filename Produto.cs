using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProduto.Models
{
    internal class Produto
    {

        public string nome;
        public double preco;
        public int quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public double ValorTotalEstoque()
        {
            double media = preco * quantidade;
            return media;
        }
    
        public void AdicionarQuantidade(int qtde)
        {
            quantidade += qtde; 
        }

        public void RemoverProduto(int qtde)
        {
            quantidade -= qtde;
        }

        public override string ToString()
        {
            return "A quantidade do seu"
            +  " estoque é de " + quantidade + " produtos, "
            + "e o valor total desse estoque é " + ValorTotalEstoque();
        }
    }
}
