using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02Estoque
{
    //CLASSE PRODUTO
    public class Produto
    {
        //VARIAVEIS
        public string nomeP;
        public double precoP;
        public int quantP;

        // CONSTRUTOR
        public Produto(string nome, double preco, int quantidade)
        {
            nomeP = nome;
            precoP = preco;
            quantP = quantidade;
        }

        //METODO PARA SABER O VALOR TOTAL NO ESTOQUE
        public double ValorTotalEmEstoque() 
        {
            return precoP * quantP;
        }

        //METODO PARA ADICIONAR PRODUTO NO ESTOQUE
        public void AdicionarProduto(int quantidade)
        {
            quantP += quantidade;
        }

        //METODO PARA REMOVER PRODUTO DO ESTOQUE
        public void RemoverProdutos(int quantidade) 
        {
                quantP -= quantidade;
        }

    }
}
