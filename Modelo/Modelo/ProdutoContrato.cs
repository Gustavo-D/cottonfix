using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelo
{
    public class ProdutoContrato
    {
        public int IdProdutoContrato { get; set; }
        public int IdContrato { get; set; }
        public int IdStatus { get; set; }
        public double Quantidade { get; set; }
        public double ValorTotal { get; set; }
        public double ICMS { get; set; }
        public string CondicoesPagamento { get; set; }
        public int Fardos { get; set; }
        public int Lote { get; set; }
        public int Cor { get; set; }
        public int TipoFolha { get; set; }
        public double PrecoNegociado { get; set; }
        public string Safra { get; set; }
    }
}
