using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Modelo;
using Modelo.Modelo;
using ControllerCottonFix.Interfaces;
using System.Collections;

namespace ControllerCottonFix
{
    public class Login
    {
        private string username;
        private string password;
        private Usuario usuario { get; set; }
        private string storedPassword;
        private bool validouSenha = false;
        private ulong id;
        private ulong? idAcesso;

        public Login(Usuario usuario)
        {
            this.usuario = usuario;
            username = usuario.Login.ToUpperInvariant();
            password = usuario.Senha;
        }
        public Tuple<ulong, ulong?, string> logar(Login login)
        {
            username = username.ToUpperInvariant();
            List<Usuario> listaUsuario = new List<Usuario>(1);
            try
            {
                using (Conexao.GetInstance)
                {
                    Conexao.Abrir();
                    ICRUD<Usuario> ControllerUsuario = new CtrlUsuario(Conexao.GetInstance);
                    listaUsuario = ControllerUsuario.Listar().ToList();
                    Conexao.Fechar();
                }
            }
            catch (Exception ex)
            {
                return new Tuple<ulong, ulong?, string>(0, 0, ex.ToString());
            }
            foreach (Usuario usuario in listaUsuario)
            {
                string curStoredUsername = usuario.Login.ToUpperInvariant();
                storedPassword = usuario.Senha;
                if (curStoredUsername == username)
                {
                    //OBS: IdUsuario e IdAcesso deveriam ser do tipo 'ulong' e 'ulong?', não 'int' e 'int?'.
                    id = (ulong)usuario.IdUsuario;
                    idAcesso = (ulong)usuario.IdAcesso;
                    validouSenha = CryptoHash.Verify(storedPassword, password);
                }
                else
                {
                    CryptoHash.Verify(storedPassword, password);
                }
            }
            if (validouSenha)
            {
                return new Tuple<ulong, ulong?, string>(id, idAcesso, username);
            }
            return new Tuple<ulong, ulong?, string>(0, 0, null);
        }
    }
}
