using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoDollar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cotacao cotacao;
            int opcaoConsulta = 0;

            do
            {

                try
                {
                    Console.WriteLine("[ 1 ] - Consulta de cotação por data");
                    Console.WriteLine("[ 2 ] - Consulta de cotação por período");
                    Console.WriteLine("[ 3 ] - Consulta última cotação");
                    Console.WriteLine("[ 0 ] - Sair");
                    Console.WriteLine("Digite a opção desejada:");

                    opcaoConsulta = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a série temporal:");

                    var serie = Int32.Parse(Console.ReadLine());
                    decimal valorCotacao = 0;

                    cotacao = new Cotacao(serie);

                    switch (opcaoConsulta)
                    {
                        case 1:
                            Console.WriteLine("Digite a data para consulta");
                            var data = Console.ReadLine();

                            valorCotacao = cotacao.CotacaoPorData(data);
                            Console.WriteLine(valorCotacao);
                            break;
                        case 2:
                            Console.WriteLine("Digite a inicial:");
                            var dataInicial = Console.ReadLine();

                            Console.WriteLine("Digite a final:");
                            var dataFinal = Console.ReadLine();

                            valorCotacao = cotacao.CotacaoPorPeriodo(dataInicial,dataFinal);
                            Console.WriteLine(valorCotacao);
                            break;
                        case 3:
                            var ultimaCotacao = cotacao.UltimoValorSerie();

                            Console.WriteLine($"Fonte: {ultimaCotacao.fonte}");
                            Console.WriteLine($"Nome: {ultimaCotacao.nomeCompleto}");
                            Console.WriteLine($"Data: {ultimaCotacao.ultimoValor.dia}/{ultimaCotacao.ultimoValor.mes}/{ultimaCotacao.ultimoValor.ano} ");
                            Console.WriteLine($"Valor: {ultimaCotacao.ultimoValor.svalor}");
                            Console.WriteLine();
                            break;
                    }

                    Console.ReadKey();
                    Console.Clear();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (opcaoConsulta != 0);

        }

    }
}

