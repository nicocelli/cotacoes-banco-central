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
            decimal valorCotacao = 0;
            int opcao = 0;
            var cotacao = new Cotacao();

            do
            {

                try
                {
                    Console.WriteLine("[ 1 ] - Consulta de cotação por data");
                    Console.WriteLine("[ 2 ] - Ultima cotação");
                    Console.WriteLine("[ 0 ] - Sair");
                    Console.WriteLine("Digite a opção desejada:");

                    var tipoConsulta = Int32.Parse(Console.ReadLine());

                    cotacao.ExibirOpcoesCotacao();

                    Console.WriteLine("Digite a moeda desejada para exibir a contação");

                    opcao = Int32.Parse(Console.ReadLine());

                    switch (tipoConsulta)
                    {
                        case 1:
                            Console.WriteLine("Digite a data para consulta");
                            var data = Console.ReadLine();
                            valorCotacao = cotacao.CotacaoPorData((TipoCotacao)opcao, data);
                            break;
                        case 2:
                            var ultimaCotacao = cotacao.UltimoValorSerie((TipoCotacao)opcao);
                            Console.WriteLine($"Fonte: {ultimaCotacao.fonte}");
                            Console.WriteLine($"Nome: {ultimaCotacao.nomeCompleto}");
                            Console.WriteLine($"Data: {ultimaCotacao.ultimoValor.dia}/{ultimaCotacao.ultimoValor.mes}/{ultimaCotacao.ultimoValor.ano} ");
                            Console.WriteLine($"Valor: {ultimaCotacao.ultimoValor.svalor}");
                            Console.WriteLine();
                            break;
                    }

                    Console.WriteLine(valorCotacao);
                    Console.ReadKey();
                    Console.Clear();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (opcao != 0);

        }

    }
}

