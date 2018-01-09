using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Modelo;
using ControllerCottonFix.Interfaces;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using Modelo;
using System.Windows.Forms;

namespace ControllerCottonFix
{
    public class CtrlUsuario : ICRUD<Usuario>, IDisposable
    {
        private Conexao _Connection;

        public CtrlUsuario(Conexao conexao)
        {
            this._Connection = conexao;
        }

        public Usuario Criar(Usuario model)
        {
            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO USUARIO (ID_ACESSO,ENDERECO_EMAIL, LOGIN, SENHA, SMTP, PORTA, STATUS, TELEFONE) VALUES (@ID_ACESSO,@ENDERECO_EMAIL, @LOGIN, @SENHA, @SMTP, @PORTA, @STATUS, @TELEFONE)";

                cmd.Parameters.Add("@ID_ACESSO", SqlDbType.Int).Value = model.IdAcesso;
                cmd.Parameters.Add("@ENDERECO_EMAIL", SqlDbType.NVarChar).Value = model.Email;
                cmd.Parameters.Add("@LOGIN", SqlDbType.NVarChar).Value = model.Login;
                cmd.Parameters.Add("@SENHA", SqlDbType.NVarChar).Value = model.Senha;
                cmd.Parameters.Add("@SMTP", SqlDbType.NVarChar).Value = model.SMTP;
                cmd.Parameters.Add("@PORTA", SqlDbType.Int).Value = model.Porta;               
                cmd.Parameters.Add("@STATUS", SqlDbType.Bit).Value = model.Status;               
                cmd.Parameters.Add("@TELEFONE", SqlDbType.BigInt).Value = model.Telefone;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return model;
                }
            }

            return default(Usuario);
        }

        public bool Atualizar(Usuario model)
        {
            bool retorno = false;

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE USUARIO SET ID_ACESSO=@ID_ACESSO, ENDERECO_EMAIL=@ENDERECO_EMAIL, LOGIN=@LOGIN, SENHA=@SENHA, SMTP=@SMTP, PORTA=@PORTA, STATUS=@STATUS, TELEFONE=@TELEFONE WHERE ID_USUARIO=@ID_USUARIO";

                cmd.Parameters.Add("@ID_USUARIO", SqlDbType.Int).Value = model.IdUsuario;
                cmd.Parameters.Add("@ID_ACESSO", SqlDbType.Int).Value = model.IdAcesso;
                cmd.Parameters.Add("@ENDERECO_EMAIL", SqlDbType.NVarChar).Value = model.Email;
                cmd.Parameters.Add("@LOGIN", SqlDbType.NVarChar).Value = model.Login;
                cmd.Parameters.Add("@SENHA", SqlDbType.NVarChar).Value = model.Senha;
                cmd.Parameters.Add("@SMTP", SqlDbType.NVarChar).Value = model.SMTP;
                cmd.Parameters.Add("@PORTA", SqlDbType.Int).Value = model.Porta;
                cmd.Parameters.Add("@STATUS", SqlDbType.Bit).Value = model.Status;
                cmd.Parameters.Add("@TELEFONE", SqlDbType.BigInt).Value = model.Telefone;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return retorno = true;
                }
                return retorno;
            }
        }

        public bool Excluir(Usuario model)
        {
            bool retorno = false;
            if (model.Status == true)
            {
                model.Status = false;
            }
            else
            {
                model.Status = true;
            }

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE USUARIO SET STATUS=@STATUS WHERE ID_USUARIO=@ID_USUARIO";

                cmd.Parameters.Add("@STATUS", SqlDbType.Bit).Value = model.Status;
                cmd.Parameters.Add("@ID_USUARIO", SqlDbType.Int).Value = model.IdUsuario;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public Usuario PesquisarCodigo(int codigoId)
        {
            Usuario usuario = null;

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "  SELECT U.ID_ACESSO, U.ENDERECO_EMAIL , U.LOGIN , U.SENHA , U.SMTP, U.PORTA, U.STATUS, U.TELEFONE, A.DESCRICAO FROM USUARIO AS U LEFT JOIN ACESSO AS A ON U.ID_ACESSO = A.ID_ACESSO WHERE U.ID_USUARIO = @ID_USUARIO";

                cmd.Parameters.Add("@ID_USUARIO", SqlDbType.Int).Value = codigoId;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        usuario = new Usuario();
                        reader.Read();

                        usuario.IdAcesso = reader.GetInt32(0);
                        usuario.Email = reader.GetString(1);
                        usuario.Login = reader.GetString(2);
                        usuario.Senha = reader.GetString(3);
                        usuario.SMTP = reader.GetString(4);
                        usuario.Porta = reader.GetInt32(5);
                        usuario.Status = reader.GetBoolean(6);
                        usuario.Telefone = reader.GetInt64(7);
                        usuario.IdAcesso = reader.GetInt32(0);
                        usuario.AcessoDescricao = reader.GetString(8);
                    }
                }
            }
            return usuario;
        }

        public Collection<Usuario> Listar()
        {
            Collection<Usuario> UsuariosListados = new Collection<Usuario>();

            using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM USUARIO";

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow i in tabela.Rows)
                    {
                        Usuario usuario = new Usuario()
                        {
                            IdUsuario = Convert.ToInt32(i["ID_USUARIO"]),
                            IdAcesso = Convert.ToInt32(i["ID_ACESSO"]),
                            Email = i["ENDERECO_EMAIL"].ToString(),
                            Login = i["LOGIN"].ToString(),
                            Senha = i["SENHA"].ToString(),
                            SMTP = i["SMTP"].ToString(),
                            Porta = Convert.ToInt32(i["Porta"]),
                            Status = Convert.ToBoolean(i["STATUS"]),
                            Telefone = Convert.ToInt64(i["TELEFONE"])
                        };

                        if (usuario.IdAcesso.Equals(1))
                        {
                            usuario.Cargo = "Administrador";
                        }
                        else if (usuario.IdAcesso.Equals(2))
                        {
                            usuario.Cargo = "Logística";
                        }
                        else if (usuario.IdAcesso.Equals(3))
                        {
                            usuario.Cargo = "Comercial";
                        }
                        UsuariosListados.Add(usuario);

                    }
                }
            }
            return UsuariosListados;
        }

        public Usuario Pesquisarlogin(string login)
        {           
            if (!string.IsNullOrEmpty(login))
            {
                using (SqlCommand cmd = Conexao.GetDBConnection().CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM USUARIO WHERE LOGIN=@LOGIN";

                    cmd.Parameters.Add("@LOGIN", SqlDbType.NVarChar).Value = login.ToUpper();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            Usuario usuario = new Usuario()
                            {
                                IdUsuario = reader.GetInt32(0) ,
                                IdAcesso = reader.GetInt32(1) ,
                                Email = reader.GetString(2) ,
                                Login = reader.GetString(3) ,
                                Senha = reader.GetString(4) ,
                                SMTP = reader.GetString(5) ,
                                Porta = reader.GetInt32(6) ,
                                Status = reader.GetBoolean(7) ,
                                Telefone = reader.GetInt64(8) 
                            };
                            return usuario;
                        }
                    }
                }
            }
            return default(Usuario);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}