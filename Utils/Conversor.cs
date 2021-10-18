using System;
using System.Linq;
using System.Text;

namespace Cafeine_DinDin_Backend.Utils
{
    public class Conversor
    {
        //convert string para base64
        static public string EncodeToBase64(string texto)
        {
            try
            {
                byte[] textoAsBytes = System.Text.Encoding.ASCII.GetBytes(texto);
                string resultado = System.Convert.ToBase64String(textoAsBytes);
                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //converte de base64 para texto
        static public string DecodeFrom64(string dados)
        {
            try
            {
                byte[] dadosAsBytes = System.Convert.FromBase64String(dados);
                string resultado = System.Text.ASCIIEncoding.ASCII.GetString(dadosAsBytes);
                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }
        static public byte[] DecodeFrom64ToBytes(string dados)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(dados);
                return bytes;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static string RandomString(int length)
        {        
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new(); 
        
            string str = new(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return str;
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
    
}
