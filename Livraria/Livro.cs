using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Livraria
{
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; private set; }
        public string Edicao { get; private set; }
        public string Editora { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; private set; }
        public double Estoque { get; private set; }
        
        public Livro()
        {

        }
        public Livro(string titulo, string autor, string edicao, string editora, double preco, int quantidade, double estoque)
        {
            Titulo = titulo;
            Autor = autor;
            Edicao = edicao;
            Editora = editora;
            Preco = preco;
            Quantidade = quantidade;
            Estoque = estoque;           

        }

        public Livro(string titulo, double preco, int quantidade)
        {
            Titulo = titulo;
            Preco = preco;
            Quantidade = quantidade;
                        
        }

        public void ValorEstoque()
        {
           Estoque = Preco * Quantidade;
             
        }

        public void Venda(int quant)
        {
            Quantidade -= quant;
        }

        public void RepoEstoque(int quant)
        {
            Quantidade += quant;
        }

        public override string ToString()
        {
            return "Livros cadastrados: " + Titulo
                + ", "
                + Preco.ToString("F2")
                + ", "
                + Quantidade
                + " , Valor do Estoque: "
                + Estoque.ToString("F2");
        }
    }
}
