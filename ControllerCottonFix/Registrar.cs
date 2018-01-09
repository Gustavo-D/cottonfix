using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Modelo;
using Modelo.Modelo;
using ControllerCottonFix.Interfaces;

namespace ControllerCottonFix
{
    public class Registrar
    {
        private string username;
        private string password;
        private string email;
        //
        //ficou faltando no BD COTTONFIX_REVISADO --> usuario.Nome;
        //
        private Usuario usuario { get; set; }

        public Registrar(Usuario usuario)
        {
            this.usuario = usuario;
            username = usuario.Login;
            password = usuario.Senha;
            email = usuario.Email;
        }
        public string adicionarUsuario(Registrar registrar)
        {
            email = email.ToLowerInvariant();
            username = username.ToUpperInvariant();
            Regex regex = new Regex("[^A-Z0-9_]");
            Regex emailRegex = new Regex("[^a-z0-9_.@]");
            string regexedUsername = regex.Replace(username, String.Empty);
            usuario.Login = regexedUsername;
            string regexedEmail = emailRegex.Replace(email, String.Empty);
            if (regexedEmail != email)
            {
                return "Email inválido. Tente novamente." + email + regexedEmail;
            }
            List<Usuario> listaUsuario = new List<Usuario>(1);
            try
            {
                using (Conexao.GetInstance)
                {
                    Conexao.Abrir();

                    string curStoredUsername = usuario.Login.ToUpperInvariant();
                    string curStoredEmail = usuario.Email.ToLowerInvariant();
                    ICRUD<Usuario> ControllerUsuario = new CtrlUsuario(Conexao.GetInstance);
                    listaUsuario = ControllerUsuario.Listar().ToList();

                    foreach (Usuario usuario in listaUsuario)
                    {
                        curStoredUsername = usuario.Login.ToUpperInvariant();
                        curStoredEmail = usuario.Email.ToLowerInvariant();
                        if (curStoredUsername == username || curStoredEmail == email)
                        {
                            //OBS: IdUsuario e IdAcesso deveriam ser do tipo 'ulong' e 'ulong?', não 'int' e 'int?'.
                            return "Usuário ou email já registrados. Tente novamente.";
                        }
                    }

                    CryptoHash cryptohash = new CryptoHash(password);
                    string cryptoHashStr = cryptohash.GetCryptoHash(cryptohash);
                    usuario.Senha = cryptoHashStr;
                    ControllerUsuario.Criar(usuario);

                    Conexao.Fechar();

                    if (regexedUsername != username)
                    {
                        return "Usuário " + usuario.Login + " continha caracteres não permitidos e foi modificado para " + regexedUsername + " e registrado com sucesso.";
                    }
                    else
                    {
                        return "Usuário " + usuario.Login + " registrado com sucesso";
                    }
                }
            }
            catch (Exception ex)
            {
                return (ex.Message);
            }
        }
    }
}

