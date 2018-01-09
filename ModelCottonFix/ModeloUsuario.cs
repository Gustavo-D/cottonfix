using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace ModelCottonFix
{
    public class ModeloUsuario
    {
        private Int32 PortaSMTP;
        private long Telefone;
        private string EnderecoSMTP;
        private string Username;
        private string Password;
        private string Acesso;
        private string Email;
        private string Nome;

        public ModeloUsuario(Int32 portaSMTP, long telefone, string acesso, string enderecoSMTP, string username, string password, string email, string nome)
        {
            this.Acesso = acesso;
            this.PortaSMTP = portaSMTP;
            this.Telefone = telefone;
            this.EnderecoSMTP = enderecoSMTP;
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.Nome = nome;
        }
        public string adicionarUsuario()
        {
            Email = Email.ToLowerInvariant();
            Username = Username.ToUpperInvariant();
            Regex regex = new Regex("[^A-Z0-9_]");
            Regex emailRegex = new Regex("[^a-z0-9_.@]");
            string regexedUsername = regex.Replace(Username, String.Empty);
            string regexedEmail = emailRegex.Replace(Email, String.Empty);

            if (regexedEmail != Email)
            {
                return "Email inválido. Tente novamente." + Email + regexedEmail;
            }

            bool regexWarn = false;

            if (regexedUsername != Username)
            {
                regexWarn = true;
            }

            SqlConnection sqlcon = new SqlConnection("Data Source =(local);Initial Catalog=COTTONFIX2;User ID=sa;Password=Cott0nfix");
            StringBuilder sb = new StringBuilder();
            SqlCommand cmdCheck = new SqlCommand("SELECT * FROM dbo.USUARIO WHERE LOGIN=@User OR EMAIL=@Email", sqlcon);

            if (regexWarn)
            {
                cmdCheck.Parameters.AddWithValue("User", regexedUsername.ToUpperInvariant());
            }
            else
            {
                cmdCheck.Parameters.AddWithValue("User", username.ToUpperInvariant());
            }

            cmdCheck.Parameters.AddWithValue("Email", email.ToLowerInvariant());
            SqlDataAdapter da = new SqlDataAdapter(cmdCheck);
            DataTable dt = new DataTable();
            sqlcon.Open();
            da.Fill(dt);
            sqlcon.Close();

            if (dt.Rows.Count >= 1)
            {
                return "Usuário ou email já registrados. Tente novamente.";
            }
            else
            {
                if (acesso == "Administrador")
                {
                    acesso = "1";
                }
                else if (acesso == "Corretor")
                {
                    acesso = "2";
                }
                else if (acesso == "Funcionário")
                {
                    acesso = "3";
                }
                else
                {
                    return "Id de acesso inválida";
                }
                //CryptoHash cryptohash = new CryptoHash(password);
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.USUARIO VALUES (@idAcesso,@Nome, @Email, @Login, @hashedPasswd, @SMTP, @portaSMTP, @Telefone);", sqlcon);
                cmd.Parameters.AddWithValue("idAcesso", acesso);
                cmd.Parameters.AddWithValue("Nome", nome);
                cmd.Parameters.AddWithValue("Email", email);
                cmd.Parameters.AddWithValue("Login", username);
                //cmd.Parameters.AddWithValue("hashedPasswd", cryptohash.GetCryptoHash(cryptohash));
                cmd.Parameters.AddWithValue("SMTP", enderecoSMTP);
                cmd.Parameters.AddWithValue("portaSMTP", portaSMTP);
                cmd.Parameters.AddWithValue("Telefone", telefone);
                sqlcon.Open();
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                if (regexWarn)
                {
                    return "Usuário " + username + " continha caracteres não permitidos e foi modificado para " + regexedUsername + " e registrado com sucesso.";
                }

                return "Usuário " + username + " registrado com sucesso";
            }
        }
    }
}
