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
    public class CtrlStatus : IPesquisaSimples<Status>
    {
        private Conexao _Connection;

        public CtrlStatus(Conexao conexao)
        {
            this._Connection = conexao;
        }

        public Status PesquisarCodigo(int codigo)
        {
            Status status = null;

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ID_CONTRATO_STATUS, DESCRICAO FROM CONTRATO_STATUS WHERE ID_CONTRATO_STATUS=@ID_CONTRATO_STATUS";

                cmd.Parameters.Add("@ID_CONTRATO_STATUS", SqlDbType.NVarChar).Value = codigo;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        status = new Status();
                        reader.Read();

                        status.IdStatus = reader.GetInt32(0);
                        status.Descricao = reader.GetString(1);
                    }
                }
            }
            return status;

        }

        public Status PesquisarDescricao(string descricao)
        {
            Status Status = null;

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ID_CONTRATO_STATUS, DESCRICAO FROM CONTRATO_STATUS WHERE DESCRICAO=@DESCRICAO";

                cmd.Parameters.Add("@DESCRICAO", SqlDbType.NVarChar).Value = descricao;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        Status = new Status();
                        reader.Read();

                        Status.IdStatus = reader.GetInt32(0);
                        Status.Descricao = reader.GetString(1);
                    }
                }
            }
            return Status;
        }

        public Collection<Status> Listar()
        {
            Collection<Status> UsuariosListados = new Collection<Status>();

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandTimeout = 15;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ID_CONTRATO_STATUS, DESCRICAO FROM CONTRATO_STATUS";

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow i in tabela.Rows)
                    {
                        Status Status = new Status();
                        Status.IdStatus = Convert.ToInt32(i["ID_CONTRATO_STATUS"]);
                        Status.Descricao = Convert.ToString(i["DESCRICAO"]);

                        UsuariosListados.Add(Status);
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
