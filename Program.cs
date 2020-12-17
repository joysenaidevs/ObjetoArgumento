using System;
using ObjetoArgumento.classe;

namespace ObjetoArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            //criar produtos
            Produto produto = new Produto(1, "Mouse Razer 3.5", 300f);
            Produto produto1 = new Produto(1, "HeadSeat Chroma 7.1", 500f);
            Produto produto2 = new Produto(1, "Mouse Pad XPT10", 400f);

            //produtos adicionados ao carrinho
            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(produto);
            carrinho.AdicionarProduto(produto1);
            carrinho.AdicionarProduto(produto2);

            //carrinho.RemoverProduto(produto); // aqui eu removo da lista

            Produto novoProduto = new Produto();

            
            novoProduto.Codigo = 20;
            novoProduto.Nome = "Fone com microfone ";
            novoProduto.Preco = 500;

            carrinho.AlterarItem(2, novoProduto);



            carrinho.MostrarProdutos();


        }
    }
}
