using Modelo;
using ControllerCottonFix.Interfaces;
using Modelo.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerCottonFix
{
    public class CtrlAcesso : IPesquisaSimples<Acesso>, IDisposable
    {
        private Conexao _Connection;

        public CtrlAcesso(Conexao conexao)
        {
            this._Connection = conexao;
        }

        public Acesso PesquisarCodigo(int codigo)
        {
            Acesso acesso = null;

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ID_ACESSO, DESCRICAO FROM ACESSO WHERE ID_ACESSO=@ID_ACESSO";

                cmd.Parameters.Add("@ID_ACESSO", SqlDbType.NVarChar).Value = codigo;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        acesso = new Acesso();
                        reader.Read();

                        acesso.IdAcesso = reader.GetInt32(0);
                        acesso.Descricao = reader.GetString(1);
                    }
                }
            }
            return acesso;

        }

        public Acesso PesquisarDescricao(string descricao)
        {
            Acesso acesso = null;

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {                
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ID_ACESSO, DESCRICAO FROM ACESSO WHERE DESCRICAO=@DESCRICAO";

                cmd.Parameters.Add("@DESCRICAO", SqlDbType.NVarChar).Value = descricao;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        acesso = new Acesso();
                        reader.Read();

                        acesso.IdAcesso = reader.GetInt32(0);
                        acesso.Descricao = reader.GetString(1);
                    }
                }
            }
            return acesso;
        }

        public Collection<Acesso> Listar()
        {
            Collection<Acesso> UsuariosListados = new Collection<Acesso>();

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandTimeout = 15;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ID_ACESSO, DESCRICAO FROM ACESSO";

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow i in tabela.Rows)
                    {
                        Acesso acesso = new Acesso();
                        acesso.IdAcesso = Convert.ToInt32(i["ID_ACESSO"]);
                        acesso.Descricao = Convert.ToString(i["DESCRICAO"]);

                        UsuariosListados.Add(acesso);
                    }
                }
            }
            return UsuariosListados;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}