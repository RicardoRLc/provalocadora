using System;
using Cliente;

namespace Cliente
{
	public class Principal
	{

		public static void Main(String[] args)
		{
			


			Console.WriteLine(" ++++ BlockBUSTER +++++");

			// Clientes

			ClienteLoc cliente1 = new ClienteLoc(1, "Fulano  de Ramos", "01/11/1998", "135.723.187-11", 3);
			ClienteLoc cliente2 = new ClienteLoc(2, "Salvana Sofia", "18/07/1958", "276.656.436-55", 2);
			ClienteLoc cliente3 = new ClienteLoc(3, "Bombom Docinho", "20/11/2201", "321.546.754-78", 3);
			ClienteLoc cliente4 = new ClienteLoc(4, "Pepeu e nenem", "11/02/1989", "023.855.499-05", 2);
			ClienteLoc cliente5 = new ClienteLoc(5, "Juca Tifuri", "03/08/1981", "456.456.898-89", 3);

			// crinado os Filmes 

			Filme filme1 = new Filme(1, "Top GUN 2", "25/06/2020",
					"Depois de mais de 30 anos de serviço como um dos principais aviadores da Marinha, Pete Maverick Mitchell está de volta, rompendo os limites como um piloto de testes corajoso. No mundo contemporâneo das guerras tecnológicas, Maverick enfrenta drones e prova que o fator humano ainda é essencial\n",
					4.5, 5);
			Filme filme2 = new Filme(2, "Mad MAX", "05/11/1981",
					"Mad Max é uma franquia multi-media australiana do gênero ficção científica, contendo elementos de ação baseada em um futuro pós-apocalíptico, criada por James McCausland e George Miller. Começou em 1979 com o filme Mad Max, seguido por Mad Max 2: The Road Warrior e Mad Max Beyond Thunderdome\n",
					3.5, 3);
			Filme filme3 = new Filme(3, "Panico", "18/12/1998",
					" é uma série de filmes americana de suspense e terror criada por Kevin Williamson e Wes Craven. A série é composta por quatro filmes e estrelada por Neve Campbell, Courteney Cox e David Arquette, ela arrecadou mais de 600 milhões de dólares em bilheterias do mundo todo\n",
					2.5, 2);
			Filme filme4 = new Filme(4, "O iluminado", "25/12/1980",
					"Jack Torrance se torna caseiro de inverno do isolado Hotel Overlook, nas montanhas do Colorado, na esperança de curar seu bloqueio de escritor. Ele se instala com a esposa Wendy e o filho Danny, que é atormentando por premonições. Jack não consegue escrever e as visões de Danny se tornam mais perturbadoras. O escritor descobre os segredos sombrios do hotel e começa a se transformar em um maníaco homicida, aterrorizando sua família.\n",
					2.5, 1);
			Filme filme5 = new Filme(5, "Cidade de Deus", "30/08/2002",
					"Nas favelas do Rio de Janeiro dos anos 1970, dois rapazes seguem caminhos diferentes. Buscapé é um fotógrafo que registra o cotidiano violento do lugar, e Zé Pequeno é um ambicioso traficante que usa as fotos de Buscapé para provar como é durão.\n",
					3.5, 2);
			Filme filme6 = new Filme(6, "SEVEN", "15/15/1995",
					"Quando, a ponto de se aposentar, o detetive William Somerset aborda o último caso com a ajuda do recém-transferido David Mills, eles descobrem uma série de assassinatos. Logo percebem que estão lidando com um assassino que tem como alvo pessoas que ele acredita representar os sete pecados capitais. Somerset também faz amizade com a esposa de Mills, Tracy, que está grávida e com medo de ter a criança em uma cidade cheia de crimes.\n",
					2.5, 2);
			Filme filme7 = new Filme(7, "TITANIC", "16/01/1998",
					"Um artista pobre e uma jovem rica se conhecem e se apaixonam na fatídica jornada do Titanic, em 1912. Embora esteja noiva do arrogante herdeiro de uma siderúrgica, a jovem desafia sua família e amigos em busca do verdadeiro amor.\n",
					3.5, 3);
			Filme filme8 = new Filme(8, "MATRIX", "10/6/1999",
					"The Matrix é uma franquia de ficção científica criada pelas irmãs Wachowski e distribuída pela Warner Bros. Pictures. A série começou com o filme The Matrix, e continuou com duas continuações, The Matrix Reloaded e The Matrix Revolutions.\n",
					3.5, 1);
			Filme filme9 = new Filme(9, "Joe e as baratas", "26/07/1996",
					"O azarado Joe se muda para um novo apartamento em Nova York, infestado por milhares de baratas surreais que cantam e dançam. Ao se tornarem amigos, os insetos acabam mudando a sorte de Joe e o ajudam a conquistar uma linda moça.\n",
					2.5, 3);
			Filme filme10 = new Filme(10, "Zohan", "06/06/2008",
					"Cansado de todas as lutas em seu país, um lendário militar israelense chamado Zohan finge sua própria morte e se muda para Nova York, onde pode realizar seu grande sonho: tornar-se um cabeleireiro famoso.\n",
					4.5, 8);

			 			 			
			Locacao locacao;
			int idCliente = 0;

			do
			{
				Console.WriteLine("\nQual o ID do Cliente?: ");

				String entrada = Console.ReadLine();
				idCliente = Convert.ToInt32(entrada);
				
				switch (idCliente)
				{
					case 1:
						cliente1.mostrarCliente(); 
						locacao = new Locacao(01, cliente1);      // Método locação de novo filme
						filme1.mostrarFilme();                                           
						filme6.mostrarFilme();             // Método para imprimir o filme
						filme10.mostrarFilme();
						locacao.AdicFilme(filme1);        // Método para adicionar filme
						locacao.AdicFilme(filme6);        
						locacao.AdicFilme(filme10);
						Console.WriteLine(" TOTAL DAS LOCAÇÕES: R$ " + locacao.PrecoTotal());
						Console.WriteLine(" DEVOLVER EM: " + locacao.calculoData());
						Console.WriteLine(" Quantidade de FILMEES: " + locacao.QtdeFilmesLoc());
						Console.WriteLine("\n +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
						break;

					case 2:
						cliente2.mostrarCliente();
						locacao = new Locacao(02, cliente2);
						filme2.mostrarFilme();
						filme7.mostrarFilme();
						locacao.AdicFilme(filme2);
						locacao.AdicFilme(filme7);
						locacao.AdicFilme(filme10);
						Console.WriteLine(" TOTAL DAS LOCAÇÕES: R$ " + locacao.PrecoTotal());
						Console.WriteLine(" DEVOLVER EM: " + locacao.calculoData());
						Console.WriteLine(" Quantidade de FILMEES: " + locacao.QtdeFilmesLoc());
						Console.WriteLine("\n +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
						break;

					case 3:
						cliente3.mostrarCliente();
						locacao = new Locacao(03, cliente3);
						filme3.mostrarFilme();
						filme6.mostrarFilme();
						filme7.mostrarFilme();
						filme8.mostrarFilme();
						locacao.AdicFilme(filme3);
						locacao.AdicFilme(filme6);
						locacao.AdicFilme(filme7);
						locacao.AdicFilme(filme8);
						locacao.AdicFilme(filme10);
						Console.WriteLine(" TOTAL DAS LOCAÇÕES: R$ " + locacao.PrecoTotal());
						Console.WriteLine(" DEVOLVER EM: " + locacao.calculoData());
						Console.WriteLine(" Quantidade de FILMEES: " + locacao.QtdeFilmesLoc());
						Console.WriteLine("\n +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
						break;

					case 4:
						cliente4.mostrarCliente();
						locacao = new Locacao(04, cliente1);
						filme4.mostrarFilme();
						filme9.mostrarFilme();
						locacao.AdicFilme(filme4);
						locacao.AdicFilme(filme9);
						locacao.AdicFilme(filme10);
						Console.WriteLine(" TOTAL DAS LOCAÇÕES: R$ " + locacao.PrecoTotal());
						Console.WriteLine(" DEVOLVER EM: " + locacao.calculoData());
						Console.WriteLine(" Quantidade de FILMEES: " + locacao.QtdeFilmesLoc());
						Console.WriteLine("\n +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
						break;

					case 5:
						cliente5.mostrarCliente();
						locacao = new Locacao(05, cliente1);
						filme1.mostrarFilme();
						filme5.mostrarFilme();
						filme10.mostrarFilme();
						locacao.AdicFilme(filme1);
						locacao.AdicFilme(filme5);
						locacao.AdicFilme(filme10);
						locacao.AdicFilme(filme10);
						Console.WriteLine(" TOTAL DAS LOCAÇÕES: R$ " + locacao.PrecoTotal());
						Console.WriteLine(" DEVOLVER EM: " + locacao.calculoData());
						Console.WriteLine(" Quantidade de FILMEES: " + locacao.QtdeFilmesLoc());
						Console.WriteLine("\n +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
						break;

				}
			} while (idCliente <= 5);
		}
	}
}