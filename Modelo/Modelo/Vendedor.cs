using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelo
{
    public class Vendedor : Pessoa
    {
        public Vendedor()
        {
            this.ContratosNegociados = new HashSet<Contrato>();
            this._TelefonesCadastrados = new HashSet<Telefone>();
            this._EnderecosCadastrados = new HashSet<Endereco>();
        }

        public int IdVendedor { get; set; }

        public virtual ICollection<Contrato> ContratosNegociados { get; set; }
    }
}
