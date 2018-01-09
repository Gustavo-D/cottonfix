using System;
using Modelo;
using ControllerCottonFix.Interfaces;
using Modelo.Modelo;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace ControllerCottonFix
{
    public class CtrlEndereco : IAtualizaInsere<Endereco>, IDisposable
    {
        private Conexao _Connection;

        public CtrlEndereco(Conexao conexao)
        {
            this._Connection = conexao;
        }

        public Endereco Atualizar(Endereco model)
        {
            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE ENDERECO SET ID_PESSOA=@ID_PESSOA, RUA=@RUA, NUMERO=@NUMERO, BAIRRO=@BAIRRO, COMPLEMENTO=@COMPLEMENTO, CEP=@CEP, CIDADE=@CIDADE, UF=@UF, OBSERVACAO=@OBSERVACAO WHERE ID_ENDERECO=@ID_ENDERECO";

                cmd.Parameters.Add("@ID_PESSOA", SqlDbType.Int).Value = model.IdPessoa;
                cmd.Parameters.Add("@RUA", SqlDbType.NVarChar).Value = model.Rua;
                cmd.Parameters.Add("@NUMERO", SqlDbType.Int).Value = model.Numero;
                cmd.Parameters.Add("@BAIRRO", SqlDbType.NVarChar).Value = model.Bairro;
                cmd.Parameters.Add("@COMPLEMENTO", SqlDbType.NVarChar).Value = model.Complemento;
                cmd.Parameters.Add("@CEP", SqlDbType.Int).Value = model.CEP;
                cmd.Parameters.Add("@CIDADE", SqlDbType.NVarChar).Value = model.Cidade;
                cmd.Parameters.Add("@UF", SqlDbType.NVarChar).Value = model.UF;
                cmd.Parameters.Add("@OBSERVACAO", SqlDbType.NVarChar).Value = model.Observacao;
                
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return model;
                }
                return default(Endereco);
            }
        }

        public Endereco Criar(Endereco model)
        {
            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO ENDERECO (ID_PESSOA, DESCRICAO, RUA, NUMERO, BAIRRO, COMPLEMENTO, CEP, CIDADE, UF, OBSERVACAO) VALUES (@ID_PESSOA, @DESCRICAO, @RUA, @NUMERO, @BAIRRO, @COMPLEMENTO, @CEP, @CIDADE, @UF, @OBSERVACAO)";

                cmd.Parameters.Add("@ID_PESSOA", SqlDbType.Int).Value = model.IdPessoa;
                cmd.Parameters.Add("@DESCRICAO", SqlDbType.NVarChar).Value = "sera retiradp";
                cmd.Parameters.Add("@RUA", SqlDbType.NVarChar).Value = model.Rua;
                cmd.Parameters.Add("@NUMERO", SqlDbType.Int).Value = model.Numero;
                cmd.Parameters.Add("@BAIRRO", SqlDbType.NVarChar).Value = model.Bairro;
                cmd.Parameters.Add("@COMPLEMENTO", SqlDbType.NVarChar).Value = model.Complemento;
                cmd.Parameters.Add("@CEP", SqlDbType.Int).Value = model.CEP;
                cmd.Parameters.Add("@CIDADE", SqlDbType.NVarChar).Value = model.Cidade;
                cmd.Parameters.Add("@UF", SqlDbType.NVarChar).Value = model.UF;
                cmd.Parameters.Add("@OBSERVACAO", SqlDbType.NVarChar).Value = model.Observacao;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return model;
                }
            }
            return default(Endereco);
        }

        public Collection<Endereco> ListaPeloId(int codigoId)
        {
            Collection<Endereco> EnderecosListados = new Collection<Endereco>();

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM ENDERECO WHERE ID_PESSOA = @ID_PESSOA";

                cmd.Parameters.Add("@ID_PESSOA", SqlDbType.Int).Value = codigoId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow i in tabela.Rows)
                    {
                        Endereco endereco = new Endereco()
                        {
                            IdPessoa = Convert.ToInt32(i["ID_PESSOA"]),
                            Rua = Convert.ToString(i["RUA"]),
                            Numero = Convert.ToInt32(i["NUMERO"]),
                            Bairro = Convert.ToString(i["BAIRRO"]),
                            Complemento = Convert.ToString(i["COMPLEMENTO"]),
                            CEP = Convert.ToInt32(i["CEP"]),
                            Cidade = Convert.ToString(i["CIDADE"]),
                            UF = Convert.ToString(i["UF"]),
                            Observacao = Convert.ToString(i["OBSERVACAO"])
                        };
                        EnderecosListados.Add(endereco);
                    }
                }                
            }
            return EnderecosListados;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}