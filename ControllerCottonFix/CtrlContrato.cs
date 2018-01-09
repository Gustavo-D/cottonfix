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
    public class CtrlContrato : ICRUD<Contrato>, IDisposable
    {
        public CtrlContrato(Conexao conexao)
        {
            this._Connection = conexao;
        }
        
        private Conexao _Connection;

        public Contrato Criar(Contrato model)
        {
            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CONTRATO VALUES (@ID_CONTRATO_STATUS, @ID_CLIENTE, @ID_VENDEDOR, @NUMERO, @ID_USUARIO, @REGISTRO_BBM, @CONDICAO_PAGAMENTO, @OBSERVACAO, @ENDERECO_CLI, @VALOR_TOTAL, @EMBARQUE, @DATA, @ORIGEM, @ENDERECO_COBRANCA, @ENDERECO_ENTREGA, @RETIRADA, @ENDERECO_VEN)";
                
                cmd.Parameters.Add("@ID_CONTRATO_STATUS", SqlDbType.Int).Value = model.IdContratoStatus;
                cmd.Parameters.Add("@ID_CLIENTE", SqlDbType.Int).Value = model.IdCliente;
                cmd.Parameters.Add("@ID_VENDEDOR", SqlDbType.Int).Value = model.IdVendedor;
                cmd.Parameters.Add("@NUMERO", SqlDbType.NVarChar).Value = model.Numero;
                cmd.Parameters.Add("@ID_USUARIO", SqlDbType.Int).Value = model.IdUsuario;
                cmd.Parameters.Add("@REGISTRO_BBM", SqlDbType.Int).Value = model.RegistroBBM;
                cmd.Parameters.Add("@CONDICAO_PAGAMENTO", SqlDbType.NVarChar).Value = model.CondicaoPagamento;
                cmd.Parameters.Add("@OBSERVACAO", SqlDbType.NVarChar).Value = model.Observacao;
                cmd.Parameters.Add("@ENDERECO_CLI", SqlDbType.NVarChar).Value = model.EnderecoCliente;
                cmd.Parameters.Add("@VALOR_TOTAL", SqlDbType.Float).Value = model.ValorTotal;
                cmd.Parameters.Add("@EMBARQUE", SqlDbType.NVarChar).Value = model.Embarque;
                cmd.Parameters.Add("@DATA", SqlDbType.DateTime).Value = model.Data;
                cmd.Parameters.Add("@ORIGEM", SqlDbType.NVarChar).Value = model.Origem;
                cmd.Parameters.Add("@ENDERECO_COBRANCA", SqlDbType.NVarChar).Value = model.EnderecoCobranca;
                cmd.Parameters.Add("@ENDERECO_ENTREGA", SqlDbType.NVarChar).Value = model.EnderecoEntrega;
                cmd.Parameters.Add("@RETIRADA", SqlDbType.NVarChar).Value = model.Retirada;
                cmd.Parameters.Add("@ENDERECO_VEN", SqlDbType.NVarChar).Value = model.EnderecoVendedor;


                if (cmd.ExecuteNonQuery() > 0)
                {
                    return model;
                }
            }

            return default(Contrato);
        }

        public bool Atualizar(Contrato model)
        {

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE CONTRATO SET ID_CONTRATO = @ID_CONTRATO, ID_CONTRATO_STATUS = @ID_CONTRATO_STATUS, ID_CLIENTE = @ID_CLIENTE, ID_VENDEDOR = @ID_VENDEDOR, NUMERO = @NUMERO, ID_USUARIO = @ID_USUARIO, REGISTRO_BBM = @REGISTRO_BBM, CONDICAO_PAGAMENTO = @CONDICAO_PAGAMENTO, OBSERVACAO = @OBSERVACAO, ENDERECO_CLI = @ENDERECO_CLI, VALOR_TOTAL = @VALOR_TOTAL, EMBARQUE = @EMBARQUE, DATA = @DATA, ORIGEM = @ORIGEM, ENDERECO_COBRANCA = @ENDERECO_COBRANCA, ENDERECO_ENTREGA = @ENDERECO_ENTREGA, RETIRADA = @RETIRADA, ENDERECO_VEN = @ENDERECO_VEN WHERE ID_CONTRATO = @ID_CONTRATO";

                cmd.Parameters.Add("@ID_CONTRATO", SqlDbType.Int).Value = model.IdContrato;
                cmd.Parameters.Add("@ID_CONTRATO_STATUS", SqlDbType.Int).Value = model.IdContratoStatus;
                cmd.Parameters.Add("@ID_CLIENTE", SqlDbType.Float).Value = model.IdCliente;
                cmd.Parameters.Add("@ID_VENDEDOR", SqlDbType.Float).Value = model.IdVendedor;
                cmd.Parameters.Add("@NUMERO", SqlDbType.Float).Value = model.Numero;
                cmd.Parameters.Add("@ID_USUARIO", SqlDbType.NVarChar).Value = model.IdUsuario;
                cmd.Parameters.Add("@REGISTRO_BBM", SqlDbType.Int).Value = model.RegistroBBM;
                cmd.Parameters.Add("@CONDICAO_PAGAMENTO", SqlDbType.Int).Value = model.CondicaoPagamento;
                cmd.Parameters.Add("@OBSERVACAO", SqlDbType.Int).Value = model.Observacao;
                cmd.Parameters.Add("@ENDERECO_CLI", SqlDbType.Int).Value = model.EnderecoCliente;
                cmd.Parameters.Add("@VALOR_TOTAL", SqlDbType.Float).Value = model.ValorTotal;
                cmd.Parameters.Add("@EMBARQUE", SqlDbType.NVarChar).Value = model.Embarque;
                cmd.Parameters.Add("@DATA", SqlDbType.DateTime).Value = model.Data;
                cmd.Parameters.Add("@ORIGEM", SqlDbType.NVarChar).Value = model.Origem;
                cmd.Parameters.Add("@ENDERECO_COBRANCA", SqlDbType.NVarChar).Value = model.EnderecoCobranca;
                cmd.Parameters.Add("@ENDERECO_ENTREGA", SqlDbType.NVarChar).Value = model.EnderecoEntrega;
                cmd.Parameters.Add("@RETIRADA", SqlDbType.NVarChar).Value = model.Retirada;
                cmd.Parameters.Add("@ENDERECO_VEN", SqlDbType.NVarChar).Value = model.EnderecoVendedor;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool Excluir(Contrato model)
        {
            using (SqlCommand cmd= Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE CONTRATO SET ID_CONTRATO_STATUS = @ID_CONTRATO_STATUS WHERE ID_CONTRATO = @ID_CONTRATO";

                cmd.Parameters.Add("@ID_CONTRATO_STATUS", SqlDbType.Int).Value = model.IdContratoStatus;
                cmd.Parameters.Add("@ID_CONTRATO", SqlDbType.Int).Value = model.IdContrato;

                if (cmd.ExecuteNonQuery() < 0)
                {
                    return true;
                }
            }
            return false;
        }

        public Contrato PesquisarCodigo(int codigoId)
        {
            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM CONTRATO WHERE ID_CONTRATO = @ID_CONTRATO";

                cmd.Parameters.Add("@ID_CONTRATO", SqlDbType.Int).Value = codigoId;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        Contrato contrato = new Contrato() {
                            IdContrato = reader.GetInt32(0),
                            IdContratoStatus = reader.GetInt32(1),
                            IdCliente = reader.GetInt32(2),
                            IdVendedor = reader.GetInt32(3),
                            Numero = reader.GetString(4),
                            IdUsuario = reader.GetInt32(5),
                            RegistroBBM = reader.GetInt32(6),
                            CondicaoPagamento = reader.GetString(7),
                            Observacao = reader.GetString(8),
                            EnderecoCliente = reader.GetString(9),
                            ValorTotal = reader.GetDouble(10),
                            Embarque = reader.GetString(11),
                            Data = reader.GetString(12) ,
                            Origem = reader.GetString(13) ,
                            EnderecoCobranca = reader.GetString(14),
                            EnderecoEntrega = reader.GetString(15) ,
                            Retirada = reader.GetString(16) ,
                            EnderecoVendedor = reader.GetString(17)
                        };
                        return contrato;
                    }
                }
            }
            return default(Contrato);
        }

        public Collection<Contrato> Listar()
        {
            Collection<Contrato> ContratosListados = new Collection<Contrato>();

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM CONTRATO";
                
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow i in tabela.Rows)
                    {
                        Contrato contrato = new Contrato()
                        {
                            IdContrato = Convert.ToInt32(i["ID_CONTRATO"]) ,
                            IdContratoStatus = Convert.ToInt32(i["ID_CONTRATO_STATUS"]) ,
                            IdCliente = Convert.ToInt32(i["ID_CLIENTE"]) ,
                            IdVendedor = Convert.ToInt32(i["ID_VENDEDOR"]) ,
                            Numero = Convert.ToString(i["NUMERO"]) , 
                            IdUsuario = Convert.ToInt32(i["ID_USUARIO"]) , 
                            RegistroBBM = Convert.ToInt32(i["REGISTRO_BBM"]) , 
                            CondicaoPagamento = Convert.ToString(i["CONDICAO_PAGAMENTO"]) ,
                            Observacao = Convert.ToString(i["OBSERVACAO"]) ,
                            EnderecoCliente = Convert.ToString(i["ENDERECO_CLI"]) , 
                            ValorTotal = Convert.ToDouble(i["VALOR_TOTAL"]) ,
                            Embarque = Convert.ToString(i["EMBARQUE"]) ,
                            Data = Convert.ToString(i["DATA"]) ,
                            Origem = Convert.ToString(i["ORIGEM"]) ,
                            EnderecoCobranca = Convert.ToString(i["ENDERECO_COBRANCA"]) , 
                            EnderecoEntrega = Convert.ToString(i["ENDERECO_ENTREGA"]) , 
                            Retirada = Convert.ToString(i["RETIRADA"]) , 
                            EnderecoVendedor = Convert.ToString(i["ENDERECO_VEN"])                            
                        };
                        ContratosListados.Add(contrato);
                    }
                }
            }
            return ContratosListados;
        }

        public int BuscaUltimoIdContrato()
        {
            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT MAX(ID_CONTRATO) FROM CONTRATO";

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        int ultimoCodigo = reader.GetInt32(0);
                        return ultimoCodigo;
                    }
                }              
            }
            return 0;
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
