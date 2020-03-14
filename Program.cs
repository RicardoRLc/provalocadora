using System;
using System.Collections.Generic;

namespace Cliente
{

	public class ClienteLoc
	{
		
		public int idCliente;
		public String nome;
		public String dataNascimento;
		public String cpf;
		public int diaDevolucao;
		public int filmesLocados;
		public List<Locacao> locacoes = new List<Locacao>();

		// Construtor

		public ClienteLoc(int idCliente, String nome, String dataNascimento, String cpf, int diaDevolucao)
		{
			// Atributos
			this.idCliente = idCliente;
			this.nome = nome;
			this.dataNascimento = dataNascimento;
			this.cpf = cpf;
			this.diaDevolucao = diaDevolucao;
			this.filmesLocados = 0;
		}

		// Método com a Quantidade de Filmes locados
		public int QtdeFimesLocCliente(int filmesLocados)
		{
			return this.filmesLocados = filmesLocados;
		}

		// Impressão Dados do CLiente
		public void mostrarCliente()
		{
			Console.WriteLine($"+++++++++++++++++ Cliente +++++++++++++++++");
			Console.WriteLine($"  Nº ID DO CLIENTE: " + idCliente);
			Console.WriteLine($" NOME COMPLETO: " + nome);
			Console.WriteLine($"  DATA DE NASCIMENTO: " + dataNascimento);
			Console.WriteLine($" CPF: " + cpf);
			Console.WriteLine($"  DIAS P/ DEVOLUÇÃO: " + diaDevolucao);
			Console.WriteLine($" QTDE DE LOCAÇÕES: " + filmesLocados);
			Console.WriteLine($"++++++++++++++++++++++");
		}
		// Adição de Locações
		public void adicionarLocacao(Locacao locacao)
		{
			this.locacoes.Add(locacao);
		}

		// Lista de locações
		public int getLocacoes()
		{
			int qtd = 0;

			foreach (Locacao locacao in this.locacoes)
			{
				foreach (Filme filme in locacao.filmes)
				{
					qtd++;
				}
			}

			return qtd;
		}
	}
}