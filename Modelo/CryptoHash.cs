using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sodium;

namespace Modelo
{
    public class CryptoHash
    {
        private const int keyStretch = 5;
        private const long ops  = 13483333;
        private const int mem  = 134217728;
        private string password { get; set; }
        //
        //ATENÇÃO: POR FAVOR NÃO ALTERAR ESTA CLASSE SEM ANTES ME FALAR. - GD
        //

        public CryptoHash(string password)
        {
            this.password = password;
        }
        private static string GetSha384Hash(string text)
        {
            using (var sha = new System.Security.Cryptography.SHA384Managed())
            {
                return Convert.ToBase64String(sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(text)));
            }
        }
        private static string Stretch(string password)
        {
            string hashedPasswd = password;
            for (int i = 0; i < keyStretch; i++)
            {
                hashedPasswd = GetSha384Hash(GetSha384Hash(hashedPasswd + password));
            }
            return hashedPasswd;
        }
        public string GetCryptoHash(CryptoHash cryptohash)
        {
            string sha384Hash = Stretch(password);
            string scryptHash = Sodium.PasswordHash.ScryptHashString(sha384Hash, ops, mem);
            return scryptHash;
        }
        public static bool Verify(string storedHash, string inputPassword)
        {
            string sha384Hash = Stretch(inputPassword);
            SodiumCore.Init();
            bool val = Sodium.PasswordHash.ScryptHashStringVerify(storedHash, sha384Hash);
            return val;
            //lembrete de como usar ScryptHashStringVerify: bool val = PasswordHash.ScryptHashStringVerify("$7$F6....0....pxzMLQ.od/XkQ1Qpi5THmDuEfCFAXH749DNJWKdlDV4$iPxlyMga4/tTxtVi.UyCthzE9WakgXQ7j4PAhi3M050", "lBeapXL/JwcY3D+XeUYcYR72+59k+Y8uaVtwB6pMBfA+Bmy0Px+kkHSeDXxoESaZ");
        }
    }
}
