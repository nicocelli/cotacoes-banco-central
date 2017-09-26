using System;
using CotacaoDollar.WsBancoCentral;

namespace CotacaoDollar
{
    public class Cotacao
    {
        private FachadaWSSGSClient WsBancoCentral = new FachadaWSSGSClient();

        /// <summary>Recupera o valor de uma série em uma determinada data (dd/MM/aaaa).</summary>
        /// <param name="tipoCotacao"></param>
        /// <param name="data">String contendo a data (dd/MM/aaaa) do valor a ser pesquisado</param>
        /// <returns>Decimal contento o valor.</returns>
        public decimal CotacaoPorData(TipoCotacao tipoCotacao, string data) => 
            WsBancoCentral.getValor((int)tipoCotacao, data);

        /// <summary>Recupera o último valor de uma determinada série e retorna um objeto do tipo WSSerieVO.</summary>
        /// <param name="tipoCotacao">WSSerieVO – Objeto série</param>
        /// <returns>WSSerieVO – Objeto sér</returns>
        public WSSerieVO UltimoValorSerie(TipoCotacao tipoCotacao) => 
            WsBancoCentral.getUltimoValorVO((int)tipoCotacao);


        public void ExibirOpcoesCotacao()
        {
            Console.WriteLine("1-Dólar(venda)");
            Console.WriteLine("10813 -  Dólar(compra)");
            Console.WriteLine("21619 -  Euro(venda)");
            Console.WriteLine("21620 -  Euro(compra)");
            Console.WriteLine("21621 -  Iene(venda)");
            Console.WriteLine("21622 -  Iene(compra)");
            Console.WriteLine("21623 -  Libra esterlina(venda)");
            Console.WriteLine("21624 -  Libra esterlina(compra)");
            Console.WriteLine("21625 -  Franco Suíço(venda)");
            Console.WriteLine("21626 -  Franco Suíço(compra)");
            Console.WriteLine("21627 -  Coroa Dinamarquesa(venda)");
            Console.WriteLine("21628 -  Coroa Dinamarquesa(compra)");
            Console.WriteLine("21629 -  Coroa Norueguesa(venda)");
            Console.WriteLine("21630 -  Coroa Norueguesa(compra)");
            Console.WriteLine("21631 -  Coroa Sueca(venda)");
            Console.WriteLine("21632 -  Coroa Sueca(compra)");
            Console.WriteLine("21633 -  Dólar Australiano(venda)");
            Console.WriteLine("21634 -  Dólar Australiano(compra)");
            Console.WriteLine("21635 -  Dólar Canadense(venda)");
            Console.WriteLine("21636 -  Dólar Canadense(compra))");
        }

    }
}
