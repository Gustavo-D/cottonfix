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
    public class CtrlVendedor : IPesquisaSimples<Vendedor>, IDisposable
    {
        private Conexao _Connection;

        public CtrlVendedor(Conexao conexao)
        {
            this._Connection = conexao;
        }        

        public bool Criar(int codigoPessoa)
        {
            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO VENDEDOR (ID_VENDEDOR) VALUES (@ID_VENDEDOR)";

                cmd.Parameters.Add("@ID_VENDEDOR", SqlDbType.Int).Value = codigoPessoa;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public Vendedor PesquisarCodigo(int codigo)
        {
            Vendedor vendedor = null;

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT P.ID_PESSOA, P.NOME, P.RAZAO_SOCIAL, P.CPF_CNPJ, P.INSCRICAO_ESTADUAL, P.ENDERECO_EMAIL, P.STATUS, P.OBSERVACAO FROM PESSOA AS P INNER JOIN VENDEDOR AS V ON P.ID_PESSOA = V.ID_VENDEDOR WHERE V.ID_VENDEDOR = @ID_PESSOA";

                cmd.Parameters.Add("@ID_PESSOA", SqlDbType.Int).Value = codigo;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        vendedor = new Vendedor()
                        {
                            IdVendedor = reader.GetInt32(0),
                            Nome = reader.GetString(1),
                            RazaoSocial = reader.GetString(2),
                            CpfCnpj = reader.GetInt64(3),
                            InscricaoEstadual = reader.GetInt64(4),
                            EnderecoEmail = reader.GetString(5),
                            Status = reader.GetBoolean(6),
                            Observacao = reader.GetString(7)
                        };
                        return vendedor;
                    }
                }
            }
            return vendedor;
        }

        public Vendedor PesquisarDescricao(string descricao)
        {
            Vendedor vendedor = null;

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ID_PESSOA, NOME, RAZAO_SOCIAL, CPF_CNPJ, INSCRICAO_ESTADUAL, ENDERECO_EMAIL, STATUS, OBSERVACAO FROM PESSOA WHERE RAZAO_SOCIAL=@NOME";

                cmd.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = descricao;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        vendedor = new Vendedor()
                        {
                            IdPessoa = reader.GetInt32(0),
                            Nome = reader.GetString(1),
                            RazaoSocial = reader.GetString(2),
                            CpfCnpj = reader.GetInt64(3),
                            InscricaoEstadual = reader.GetInt64(4),
                            EnderecoEmail = reader.GetString(5),
                            Status = reader.GetBoolean(6),
                            Observacao = reader.GetString(7)
                        };
                        return vendedor;
                    }
                }
            }
            return vendedor;
        }

        public Collection<Vendedor> Listar()
        {
            Collection<Vendedor> VendedoresListados = new Collection<Vendedor>();

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT P.ID_PESSOA, P.NOME, P.RAZAO_SOCIAL, P.CPF_CNPJ, P.INSCRICAO_ESTADUAL, P.ENDERECO_EMAIL, P.STATUS, P.OBSERVACAO FROM PESSOA AS P INNER JOIN VENDEDOR AS V ON P.ID_PESSOA = V.ID_VENDEDOR WHERE P.ID_PESSOA = V.ID_VENDEDOR";

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow i in tabela.Rows)
                    {
                        Vendedor vendedor = new Vendedor()
                        {
                            IdVendedor = Convert.ToInt32(i["ID_PESSOA"]),
                            Nome = Convert.ToString(i["NOME"]),
                            RazaoSocial = Convert.ToString(i["RAZAO_SOCIAL"]),
                            CpfCnpj = Convert.ToInt64(i["CPF_CNPJ"]),
                            InscricaoEstadual = Convert.ToInt64(i["INSCRICAO_ESTADUAL"]),
                            EnderecoEmail = Convert.ToString(i["ENDERECO_EMAIL"]),
                            Status = Convert.ToBoolean(i["STATUS"]),
                            Observacao = Convert.ToString(i["OBSERVACAO"])
                        };

                        VendedoresListados.Add(vendedor);
                    }
                }
            }
            return VendedoresListados;
        }       

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
