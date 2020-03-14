using System;
using System.Collections.Generic;

namespace Cliente
{
    public class Locacao
    {
        // Atributos
        public int idLocacao = 0;
        public ClienteLoc cliente;
        public String dataLocacao;
        public String dataDevolucao;
        public Double valorTotal;

        public List<Filme> filmes = new List<Filme>();

        public Locacao(int idLocacao, ClienteLoc cliente)
        {

            this.idLocacao = idLocacao;
            this.cliente = cliente;

            this.cliente.adicionarLocacao(this);
        }

        // Método para adicionar Filmes
        public void AdicionaFilme(Filme filme)
        {
            this.filmes.Add(filme);
        }

        // Método com o Valor Total das Locações (Preço)

        public double PrecoTotal()
        {
            double total = 0;
            foreach (Filme filme in filmes)
            {
                total += filme.valorLocacao;
            }
            return total;
        }

        // Método com a Quantidade de Filmes Locados

        public int QtdeFilmesLoc()
        {
            return this.filmes.Count;
        }

        // Método de cálculo para devolver
        public String calculoData()
        {
            DateTime dataAtual = DateTime.Now;

            return dataAtual.AddDays(cliente.diaDevolucao).ToString("dddd, dd MMMM yyyy");


        }
    }
}

