using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Burs_Basvuru_Otomasyonu
{
    class Sifreleme
    {
        public static string md5sifreleme(string sifre)
        {

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] array = Encoding.UTF8.GetBytes(sifre);

            array = md5.ComputeHash(array);

            StringBuilder sb = new StringBuilder();

            foreach (byte item in array)
            {

                sb.Append(item.ToString("x2").ToLower());
            }

            return sb.ToString();

        }

        public static string sha256(string sifre)
        {

            SHA256 sha256 = SHA256.Create();

            byte[] array = Encoding.UTF8.GetBytes(sifre);

            array = sha256.ComputeHash(array);

            StringBuilder sb = new StringBuilder();

            foreach (byte item in array)
            {

                sb.Append(item.ToString("x2").ToLower());
            }

            return sb.ToString();

        }






    }
}
