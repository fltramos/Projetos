using System;

namespace Livraria
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro;
            
            Console.WriteLine("Cadastrar Livros no Estoque");
            Console.Write("Cadastrar Titulo: ");
            string titulo = Console.ReadLine();
            Console.Write("Cadastrar Autor: ");
            string autor = Console.ReadLine();
            Console.Write("Cadastrar Edição: ");
            string edicao = Console.ReadLine();
            Console.Write("Cadastrar Editora: ");
            string editora = Console.ReadLine();
            Console.Write("Cadastrar Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Cadastrar a Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            
            livro = new Livro(titulo, preco, quantidade);
            livro.ValorEstoque();
            Console.WriteLine();
            Console.WriteLine(livro);

            Console.WriteLine();

            Console.Write("Vender Livros: ");
            int quant = int.Parse(Console.ReadLine());
            livro.Venda(quant);
            livro.ValorEstoque();
            Console.WriteLine(livro);

            Console.WriteLine();

            Console.Write("Entrada no Estoque: ");
            quant = int.Parse(Console.ReadLine());
            livro.RepoEstoque(quant);
            livro.ValorEstoque();
            Console.WriteLine(livro);
        }
    }
}
