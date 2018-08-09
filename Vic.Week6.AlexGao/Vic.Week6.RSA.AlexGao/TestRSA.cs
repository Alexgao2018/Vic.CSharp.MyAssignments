using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-<----Add some using as below---
using System.Security.Cryptography;
//using System.Text;


namespace Vic.Week6.RSA.AlexGao
{
    /// <summary>
    /// 
    /// www.cnBlogs.com/YeYe518/p/60-515-98.html
    /// 
    /// </summary>
    public class TestRSA
    {
        //---EnCrypt------------------
        //Plain text, Public Key and Private Key
        public static string RSA_Encrypt(string str_Plain_Text, out string str_Public_Key, out string str_Private_Key)
        {
            str_Public_Key = "";
            str_Private_Key = "";
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] DataToEncrypt = ByteConverter.GetBytes(str_Plain_Text);
            try
            {
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                str_Public_Key = Convert.ToBase64String(RSA.ExportCspBlob(false));
                str_Private_Key = Convert.ToBase64String(RSA.ExportCspBlob(true));

                //OAEP padding is only available on Microsoft Windows XP or later. 
                byte[] bytes_Cypher_Text = RSA.Encrypt(DataToEncrypt, false);
                str_Public_Key = Convert.ToBase64String(RSA.ExportCspBlob(false));
                str_Private_Key = Convert.ToBase64String(RSA.ExportCspBlob(true));
                string str_Cypher_Text = Convert.ToBase64String(bytes_Cypher_Text);
                return str_Cypher_Text;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("---EnCrypt Error: {0} !!", e.Message);
                return null;
            }
        }

        //---DeCrypt---------------------------------------
        static public string RSA_Decrypt(string str_Cypher_Text, string str_Private_Key)
        {
            byte[] DataToDecrypt = Convert.FromBase64String(str_Cypher_Text);
            try
            {
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                //RSA.ImportParameters(RSAKeyInfo);
                byte[] bytes_Public_Key = Convert.FromBase64String(str_Private_Key);
                RSA.ImportCspBlob(bytes_Public_Key);

                //OAEP padding is only available on Microsoft Windows XP or later. 
                byte[] bytes_Plain_Text = RSA.Decrypt(DataToDecrypt, false);
                UnicodeEncoding ByteConverter = new UnicodeEncoding();
                string str_Plain_Text = ByteConverter.GetString(bytes_Plain_Text);
                return str_Plain_Text;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("----Decrypt Error {0} !!!", e.ToString());
                return null;
            }
        }

        //----------------------------------
        public static void Go()
        {            
            try
            {
                string str_Plain_Text = "hello world";
                string str_Public_Key;
                string str_Private_Key;

                Console.WriteLine("\n--Source Plain text: {0}\n             length: {1}\n", str_Plain_Text, str_Plain_Text.Length.ToString());

                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

                string str_Cypher_Text = RSA_Encrypt(str_Plain_Text, out str_Public_Key, out str_Private_Key);
                Console.WriteLine("\n--Crpher Text:--\n" + str_Cypher_Text);
                Console.WriteLine("\n--Public Key--:\n" + str_Public_Key);
                Console.WriteLine("\n--Private  Key--:\n" + str_Private_Key);

                string str_Plain_Text2 = RSA_Decrypt(str_Cypher_Text, str_Private_Key);
                Console.WriteLine("\n\n--DeCrypt Source Text--:" + str_Plain_Text2);

                Console.WriteLine();

            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("---Encryption failed.");
            }
        } 
    }
}
