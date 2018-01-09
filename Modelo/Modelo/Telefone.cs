using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelo
{
    public class Telefone
    {        
        public int IdTelefone { get; set; }
        public int IdPessoa { get; set; }
        public string Descricao { get; set; }
        public long Numero { get; set; }
    }
}