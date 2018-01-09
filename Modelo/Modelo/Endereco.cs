using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelo
{
    public class Endereco
    {
        public int IdPessoa { get; set; }
        public int IdEndereco { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public int CEP { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Observacao { get; set; }        
    }
}