namespace ObjetoArgumento.classe
{
    public class Produto
    {
        /*CRUD (de produto) é o acrônimo da expressão do idioma Inglês, Create (Criação), Read (Consulta), Update (Atualização) e Delete (Destruição). Este acrônimo é comumente utilizado para definir as quatro operações básicas usadas em Banco de Dados Relacionais.*/
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        
        
        //o que nao retorna nada
        public Produto(){

        }
        
        //metodo construtor - nao retornar nada
        public Produto(int _codigo, string _nome, float _preco){
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;

        }
        
    }
}