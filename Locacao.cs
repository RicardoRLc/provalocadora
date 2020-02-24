﻿using System;
using System.Collections.Generic;

namespace Cliente
{
    public class Locacao
    {
        // Atributos
        public int idLoc = 0;
        public ClienteLoc cliente;
        public String dataLoc;
        public String dataDevolucao;
        public Double valorTotal;

        public List<Filme> filmes = new List<Filme>();

        public Locacao(int idLoc, ClienteLoc cliente)
        {

            this.idLoc = idLoc;
            this.cliente = cliente;

            this.cliente.adicionarLocacao(this);
        }

        // Método para adicionar Filmes
        public void AdicFilme(Filme filme)
        {
            this.filmes.Add(filme);
        }

        // Método com o Valor Total das Locações (Preço)

        public double PrecoTotal()
        {
            double total = 0;
            foreach (Filme filme in filmes)
            {
                total += filme.valorLoc;
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

            return dataAtual.AddDays(cliente.diaDev).ToString("dddd, dd MMMM yyyy");


        }
    }
}

