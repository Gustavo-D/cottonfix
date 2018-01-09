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
    public class CtrlPessoa : ICRUD<Pessoa> , IDisposable, IPesquisaSimples<Pessoa>
    {
        private Conexao _Connection;

        public CtrlPessoa(Conexao conexao)
        {
            this._Connection = conexao;
        }

        public Pessoa Criar(Pessoa model)
        {
            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO PESSOA (NOME, RAZAO_SOCIAL, CPF_CNPJ, INSCRICAO_ESTADUAL, ENDERECO_EMAIL, STATUS, OBSERVACAO) VALUES (@NOME, @RAZAO_SOCIAL, @CPF_CNPJ, @INSCRICAO_ESTADUAL, @ENDERECO_EMAIL, @STATUS, @OBSERVACAO)";

                cmd.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = model.Nome;
                cmd.Parameters.Add("@RAZAO_SOCIAL", SqlDbType.NVarChar).Value = model.RazaoSocial;
                cmd.Parameters.Add("@CPF_CNPJ", SqlDbType.BigInt).Value = model.CpfCnpj;
                cmd.Parameters.Add("@INSCRICAO_ESTADUAL", SqlDbType.BigInt).Value = model.InscricaoEstadual;
                cmd.Parameters.Add("@ENDERECO_EMAIL", SqlDbType.NVarChar).Value = model.EnderecoEmail;
                cmd.Parameters.Add("@STATUS", SqlDbType.Bit).Value = model.Status;
                cmd.Parameters.Add("@OBSERVACAO", SqlDbType.NVarChar).Value = model.Observacao;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return model;
                }
            }
            return default(Pessoa);
        }

        public bool Atualizar(Pessoa model)
        {
            bool retorno = false;
            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE PESSOA  SET NOME=@NOME, RAZAO_SOCIAL=@RAZAO_SOCIAL, CPF_CNPJ=@CPF_CNPJ, INSCRICAO_ESTADUAL=@INSCRICAO_ESTADUAL, ENDERECO_EMAIL=@ENDERECO_EMAIL, STATUS=@STATUS, OBSERVACAO=@OBSERVACAO WHERE ID_PESSOA=@ID_PESSOA";

                cmd.Parameters.Add("@ID_PESSOA", SqlDbType.Int).Value = model.IdPessoa;
                cmd.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = model.Nome;
                cmd.Parameters.Add("@RAZAO_SOCIAL", SqlDbType.NVarChar).Value = model.RazaoSocial;
                cmd.Parameters.Add("@CPF_CNPJ", SqlDbType.BigInt).Value = model.CpfCnpj;
                cmd.Parameters.Add("@INSCRICAO_ESTADUAL", SqlDbType.BigInt).Value = model.InscricaoEstadual;
                cmd.Parameters.Add("@ENDERECO_EMAIL", SqlDbType.NVarChar).Value = model.EnderecoEmail;
                cmd.Parameters.Add("@STATUS", SqlDbType.Bit).Value = model.Status;
                cmd.Parameters.Add("@OBSERVACAO", SqlDbType.NVarChar).Value = model.Observacao;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return retorno = true;
                }
                return retorno;
            }
        }

        public bool Excluir(Pessoa model)
        {
            bool retorno = false;

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE PESSOA SET STATUS=@STATUS WHERE ID_PESSOA=@ID_PESSOA";

                cmd.Parameters.Add("@STATUS", SqlDbType.Bit).Value = model.Status;
                cmd.Parameters.Add("@ID_PESSOA", SqlDbType.Int).Value = model.IdPessoa;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public Pessoa PesquisarCodigo(int codigoId)
        {
            Pessoa pessoa = null;

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ID_PESSOA, NOME, RAZAO_SOCIAL, CPF_CNPJ, INSCRICAO_ESTADUAL, ENDERECO_EMAIL, STATUS, OBSERVACAO FROM PESSOA WHERE ID_PESSOA=@ID_PESSOA";

                cmd.Parameters.Add("@ID_PESSOA", SqlDbType.Int).Value = codigoId;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        pessoa = new Pessoa()
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
                        return pessoa;
                    }
                }
            }
            return pessoa;
        }

        public Collection<Pessoa> Listar()
        {
            Collection<Pessoa> PessoasListadas = new Collection<Pessoa>();

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM PESSOA";

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow i in tabela.Rows)
                    {
                        Pessoa pessoa = new Pessoa()
                        {
                            IdPessoa = Convert.ToInt32(i["ID_PESSOA"]),
                            Nome = Convert.ToString(i["NOME"]),
                            RazaoSocial = Convert.ToString(i["RAZAO_SOCIAL"]),
                            CpfCnpj = Convert.ToInt64(i["CPF_CNPJ"]),
                            InscricaoEstadual = Convert.ToInt64(i["INSCRICAO_ESTADUAL"]),
                            EnderecoEmail = Convert.ToString(i["ENDERECO_EMAIL"]),
                            Status = Convert.ToBoolean(i["STATUS"]),
                            Observacao = Convert.ToString(i["OBSERVACAO"])
                        };

                        PessoasListadas.Add(pessoa);
                    }
                }
            }
            return PessoasListadas;
        }

        public Collection<Pessoa> Listar(string descricao)
        {
            Collection<Pessoa> PessoasListadas = new Collection<Pessoa>();

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM PESSOA WHERE NOME LIKE @NOME + '%'";

                cmd.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = descricao;

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow i in tabela.Rows)
                    {
                        Pessoa pessoa = new Pessoa()
                        {
                            IdPessoa = Convert.ToInt32(i["ID_PESSOA"]),
                            Nome = Convert.ToString(i["NOME"]),
                            RazaoSocial = Convert.ToString(i["RAZAO_SOCIAL"]),
                            CpfCnpj = Convert.ToInt64(i["CPF_CNPJ"]),
                            InscricaoEstadual = Convert.ToInt64(i["INSCRICAO_ESTADUAL"]),
                            EnderecoEmail = Convert.ToString(i["ENDERECO_EMAIL"]),
                            Status = Convert.ToBoolean(i["STATUS"]),
                            Observacao = Convert.ToString(i["OBSERVACAO"])
                        };

                        PessoasListadas.Add(pessoa);
                    }
                }
            }
            return PessoasListadas;
        }

        public Pessoa PesquisarCnpjInscricaoEstadual(long cnpj, long inscricaoEstadual)
        {
            try
            {
                Pessoa pessoa = null;
                using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT ID_PESSOA, NOME, RAZAO_SOCIAL, CPF_CNPJ, INSCRICAO_ESTADUAL, ENDERECO_EMAIL, STATUS, OBSERVACAO FROM PESSOA WHERE CPF_CNPJ=@CPF_CNPJ AND INSCRICAO_ESTADUAL=@INSCRICAO_ESTADUAL";

                    cmd.Parameters.Add("@CPF_CNPJ", SqlDbType.BigInt).Value = cnpj;
                    cmd.Parameters.Add("@INSCRICAO_ESTADUAL", SqlDbType.BigInt).Value = inscricaoEstadual;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            pessoa = new Pessoa()
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
                            return pessoa;
                        }
                    }
                    return pessoa;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Pessoa PesquisarDescricao(string descricao)
        {
            Pessoa vendedor = null;

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ID_PESSOA, NOME, RAZAO_SOCIAL, CPF_CNPJ, INSCRICAO_ESTADUAL, ENDERECO_EMAIL, STATUS, OBSERVACAO FROM PESSOA WHERE RAZAO_SOCIAL LIKE @NOME%";

                cmd.Parameters.Add("@NOME", SqlDbType.NVarChar).Value = descricao;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        vendedor = new Pessoa()
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
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
