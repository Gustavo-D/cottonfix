using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Modelo
{
    public class Usuario
    {
        public int IdAcesso { get; set; }
        public int IdUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string SMTP { get; set; }
        public int Porta { get; set; }
        public string Cargo { get; set; }
        public long Telefone { get; set; }
        public bool Status { get; set; }
        public string AcessoDescricao { get; set; }
    }
}
