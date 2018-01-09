using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelo
{
    public class Pessoa 
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Observacao { get; set; }
        public string RazaoSocial { get; set; }
        public long CpfCnpj { get; set; }
        public long InscricaoEstadual { get; set; }
        public string EnderecoEmail { get; set; }
        public bool Status { get; set; }
        public int Tipo { get; set; }

        public virtual ICollection<Telefone> _TelefonesCadastrados { get; set; }
        public virtual ICollection<Endereco> _EnderecosCadastrados { get; set; }
    }
}
