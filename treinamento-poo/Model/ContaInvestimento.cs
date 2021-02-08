using System;
using System.Collections.Generic;
using System.Text;

namespace treinamento_poo.Model
{
    /*https://blog.orama.com.br/2018/08/02/6-caracteristicas-dos-investimentos-que-voce-precisa-levar-em-conta/
    */

    public class ContaInvestimento
    {
        public string Emisssor { get; set; }

        public string Distribuidor { get; set; }

        public double fundoGarantia { get; set; }

        public Liquidez TipoLiquidez { get; set; }

        public Investimento TipoInvestimento { get; set; }

        public double TributacaoIR { get; set; }
    }

    public enum Liquidez
    {
        Diaria = 1,
        Vencimento = 2
    }

    public enum Investimento
    {
        PreFixado = 1,
        PosFixado = 2
    }
}
