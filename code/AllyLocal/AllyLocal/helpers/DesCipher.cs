using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Text.UTF8Encoding;

namespace Ally_Local.helpers
{
    class DesCipher
    {
        public static string Encrypt(string input, string key)
        {
            byte[] properkey = GetKey(key);
            byte[] inputArray = Encoding.UTF8.GetBytes(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = properkey;
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        
        public static string Decrypt(string input, string key)
        {
            byte[] properkey = GetKey(key);
            byte[] inputArray = Convert.FromBase64String(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = properkey;
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateDecryptor();
            try
            {
                byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
                tripleDES.Clear();
                return Encoding.UTF8.GetString(resultArray);
            }
            catch (System.Exception ex)
            {
            }

            return "";
        }


        public static string GetSHA256String(string text)
        {
            var UE = new UnicodeEncoding();
            var message = UE.GetBytes(text);

            var hashString = new SHA256Managed();
            var hex = string.Empty;

            var hashValue = hashString.ComputeHash(message);
            foreach (byte b in hashValue)
            {
                hex += String.Format("{0:x2}", b);
            }
            return hex;
        }

        public static byte[] GetKey(string phrase)
        {
            byte[] keyArray;
            phrase = phrase.PadRight(24);
            SHA512CryptoServiceProvider hash = new SHA512CryptoServiceProvider();
            keyArray = hash.ComputeHash(Encoding.UTF8.GetBytes(phrase));
            byte[] trimmedBytes = new byte[24];
            Buffer.BlockCopy(keyArray, 0, trimmedBytes, 0, 24);
            keyArray = trimmedBytes;
            return keyArray;
        }
    }
}