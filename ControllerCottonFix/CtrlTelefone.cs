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
    public class CtrlTelefone : IAtualizaInsere<Telefone>, IDisposable
    {
        private Conexao _Connection;

        public CtrlTelefone(Conexao conexao)
        {
            this._Connection = conexao;
        }

        public Telefone Atualizar(Telefone model)
        {
            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE TELEFONE SET ID_PESSOA=@ID_PESSOA, DESCRICAO=@DESCRICAO, NUMERO=@NUMERO WHERE ID_TELEFONE=@ID_TELEFONE";

                cmd.Parameters.Add("@ID_TELEFONE", SqlDbType.Int).Value = Convert.ToInt32(model.IdTelefone);
                cmd.Parameters.Add("@ID_PESSOA", SqlDbType.Int).Value = model.IdPessoa;
                cmd.Parameters.Add("@DESCRICAO", SqlDbType.NVarChar).Value = model.Descricao;
                cmd.Parameters.Add("@NUMERO", SqlDbType.BigInt).Value = model.Numero;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return model;
                }
                return default(Telefone);
            }
        }

        public Telefone Criar(Telefone model)
        {
            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO TELEFONE (ID_PESSOA, DESCRICAO, NUMERO) VALUES (@ID_PESSOA, @DESCRICAO, @NUMERO)";

                cmd.Parameters.Add("@ID_PESSOA", SqlDbType.Int).Value = Convert.ToInt32(model.IdPessoa);
                cmd.Parameters.Add("@DESCRICAO", SqlDbType.NVarChar).Value = model.Descricao;
                cmd.Parameters.Add("@NUMERO", SqlDbType.BigInt).Value = model.Numero;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return model;
                }
            }
            return default(Telefone);
        }

        public Collection<Telefone> ListaPeloId(int codigoId)
        {
            Collection<Telefone> TelefonesListados = new Collection<Telefone>();

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM TELEFONE WHERE ID_PESSOA = @ID_PESSOA";

                cmd.Parameters.Add("@ID_PESSOA", SqlDbType.Int).Value = codigoId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow i in tabela.Rows)
                    {
                        Telefone telefone = new Telefone()
                        {
                            IdTelefone = Convert.ToInt32(i["ID_TELEFONE"]) ,
                            IdPessoa = Convert.ToInt32(i["ID_PESSOA"]) ,
                            Descricao = Convert.ToString(i["DESCRICAO"]) ,
                            Numero = Convert.ToInt64(i["NUMERO"])
                        };

                        TelefonesListados.Add(telefone);
                    }
                }
            }
            return TelefonesListados;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
