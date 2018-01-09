using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelo
{
    public class Cliente : Pessoa
    {
        public Cliente()
        {
            this.ContratosNegociados = new HashSet<Contrato>();
            this._TelefonesCadastrados = new HashSet<Telefone>();
            this._EnderecosCadastrados = new HashSet<Endereco>();
        }

        public int IdCliente { get; set; }

        public virtual ICollection<Contrato> ContratosNegociados { get; set; }
    }
}
