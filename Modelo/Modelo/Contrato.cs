using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelo
{
    public class Contrato
    {
        public Contrato()
        {
            ProdutosContrato = new HashSet<ProdutoContrato>();
        }

        public int IdContrato { get; set; }
        public int IdContratoStatus { get; set; }

        public string Numero { get; set; }
        public int IdUsuario { get; set; }
        public int IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public int RegistroBBM { get; set; }
        public string CondicaoPagamento { get; set; }
        public string Observacao { get; set; }
        public string EnderecoCliente { get; set; }
        public double ValorTotal { get; set; }
        public string Embarque { get; set; }
        public string Data { get; set; }
        public string Origem { get; set; }
        public string EnderecoCobranca { get; set; }
        public string EnderecoEntrega { get; set; }
        public string Retirada { get; set; }
        public string EnderecoVendedor { get; set; }
        public virtual ICollection<ProdutoContrato> ProdutosContrato { get; set; }
    }
}
