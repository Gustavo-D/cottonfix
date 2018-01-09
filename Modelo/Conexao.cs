using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public sealed class Conexao : IDisposable
    {
        private static Conexao _Instance = null;
        private static SqlConnection _Connection = new SqlConnection(GetConnectionString("ANDRE"));
        
        public static Conexao GetInstance
        {
            get
            {
                if (_Instance == null)
                {
                   _Instance = new Conexao();                   
                }
                return _Instance;
            }
        }

        public static SqlConnection GetDBConnection()
        {
            return _Connection;
        }

        private static string GetConnectionString(string deQuem)
        {            
            if (deQuem == "GUSTAVO")
            {
                return @"Data Source =(local);Initial Catalog=COTTONFIX3;User ID=sa;Password=Cott0nfix;Connection Timeout=30";
            }
            else if (deQuem == "ANDRE")
            {
                return @"Data Source=.\sqlexpress;Initial Catalog=COTTONFIX_FINAL;Integrated Security=True; Timeout=30";
            }
            else if (deQuem =="ANTONIO")
            {
                return @"Data Source=.\SQLEXPRESS;Initial Catalog=CottonFix4;Integrated Security=True;Connection Timeout=30";
            }
            else

            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }       

        public static SqlConnection Abrir()
        {
            if (_Connection.State == ConnectionState.Closed)
            {
                _Connection.Open();
            }
            return _Connection;
        }

        public static void Fechar()
        {
            if (_Connection.State == ConnectionState.Open)
            {
                _Connection.Close();                
            }
        }

        public void Dispose()
        {
            Fechar();
            GC.SuppressFinalize(this);
        }

    }
}
