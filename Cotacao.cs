using System;
using CotacaoDollar.WsBancoCentral;

namespace CotacaoDollar
{
    public class Cotacao
    {
        private FachadaWSSGSClient WsBancoCentral = new FachadaWSSGSClient();
        private int _serie;
        
        /// <summary>Construtor</summary>
        /// <param name="serie">Série temporal</param>
        public Cotacao(int serie) {
            _serie = serie;
        }

        /// <summary>Recupera o valor de uma série em uma determinada data (dd/MM/aaaa).</summary>
        /// <param name="tipoCotacao"></param>
        /// <param name="data">String contendo a data (dd/MM/aaaa) do valor a ser pesquisado</param>
        /// <returns>Decimal contento o valor.</returns>
        public decimal CotacaoPorData(string data) => 
            WsBancoCentral.getValor(_serie, data);

        public decimal CotacaoPorPeriodo(string dataInicio, string dataFim) =>
            WsBancoCentral.getValorEspecial(_serie, dataInicio, dataFim);

        /// <summary>Recupera o último valor de uma determinada série e retorna um objeto do tipo WSSerieVO.</summary>
        /// <param name="tipoCotacao">WSSerieVO – Objeto série</param>
        /// <returns>WSSerieVO – Objeto sér</returns>
        public WSSerieVO UltimoValorSerie() => 
            WsBancoCentral.getUltimoValorVO(_serie);

    }
}
