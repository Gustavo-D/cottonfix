using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelo
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public int CodigoTipo { get; set; }
        public int CodigoFolha { get; set; }
        public int CodigoCor { get; set; }

        public virtual ProdutoContrato ProdutoContrato { get; set; }
    }
}
