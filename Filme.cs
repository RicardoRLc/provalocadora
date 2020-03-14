using System;

namespace Cliente
{
  public   class Filme
    {
        // Atributos
        public int idFilme;
        public String titulo;
        public String dataLancamento;
        public String sinopse;
        public Double valorLocacao;
        public int estoque;
        public int locado;

        // Construtor
        public Filme(int idFilme, String titulo, String dataLancamento, String sinopse, Double valorLocacao, int estoque)
        {
            this.idFilme = idFilme;
            this.titulo = titulo;
            this.dataLancamento = dataLancamento;
            this.sinopse = sinopse;
            this.valorLocacao = valorLocacao;
            this.estoque = estoque;
            this.locado = 0;
        }

        // Método com a Quantidade de locações Realizadas
        public void filmeLocado()
        {
            this.estoque -= 1;
            this.locado += 1;
        }

        // Informações impressas dos filmes
        public void mostrarFilme()
        {
            
            Console.WriteLine("ID DO FILME: " + idFilme);
            Console.WriteLine(" TÍTULO: " + titulo);
            Console.WriteLine(" DATA DE LANÇAMENTO: " + dataLancamento);
            Console.WriteLine(" SINOPSE: " + sinopse);
            Console.WriteLine(" VALOR DA LOCAÇÃO: R$ " + valorLocacao);
            Console.WriteLine(" QTDE EM ESTOQUE: " + estoque);
            Console.WriteLine(" QTDE DE LOCAÇÕES REALIZADAS: " + locado);
           
        }
    }
}
    

