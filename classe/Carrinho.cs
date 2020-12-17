using System;
using System.Collections.Generic;

namespace ObjetoArgumento.classe
{
    public class Carrinho
    {
        // Criar propiedade para guardar o valor total do carrinho

        public float ValorTotal { get; set; }

        //Lista do carrinho
        List<Produto> listaDeProdutos = new List<Produto>();

        //Criar método para adicionar um produto no carrinho passando todo o objeto como argumento

        public void AdicionarProduto(Produto produto){
            listaDeProdutos.Add(produto);
        }

        //metodo que remove produto do carrinho
        public void RemoverProduto(Produto produto){
            listaDeProdutos.Remove(produto);

        }

        //metodo que lista os produtos
        //Tostring serve para limitar a quantidade de casas decimais
        // != Diferente de vazio - Significa que há algo em minha lista, executando Foreach.
        public void MostrarProdutos(){
            if (listaDeProdutos != null){
                foreach (var item in listaDeProdutos)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Codigo {item.Codigo} - R${item.Preco.ToString("n2")} - Nome {item.Nome}");
                    Console.ResetColor();
                }
            }else{
                Console.WriteLine("Produto nao encontrado");
            }
        }

        //passando código e objeto
        //codigo vai buscar o produto em uma lista
        public void AlterarItem(int codigo, Produto _novoProduto){
            listaDeProdutos.Find(produto => produto.Codigo == codigo).Nome = _novoProduto.Nome;
            listaDeProdutos.Find(produto => produto.Codigo == codigo).Preco = _novoProduto.Preco;
            listaDeProdutos.Find(produto => produto.Codigo == codigo).Codigo = _novoProduto.Codigo;



        }

        public void AlterarItem(){
            
        }
        
        
    }
}