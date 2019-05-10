using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Common
{
    public class Common
    {
        public string InitialPassword()
        {
            string initialPassword = new DesHelper().Encrypt("123456");
            return initialPassword;
        }
    }
    public class DesHelper
    {
        string _iv = "9AUPABCD";
        string _key = "9d8f7g6h";
        public string IV
        {
            get { return _iv; }
            set { _iv = value; }
        }
        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }
        public string Encrypt(string sourceString)
        {
            byte[] btKey = Encoding.Default.GetBytes(_key);
            byte[] btIv = Encoding.Default.GetBytes(_iv);
            var des = new DESCryptoServiceProvider();
            using (var ms = new MemoryStream())
            {
                byte[] inData = Encoding.Default.GetBytes(sourceString);
                try
                {
                    using (var cs = new CryptoStream(ms, des.CreateEncryptor(btKey, btIv), CryptoStreamMode.Write))
                    {
                        cs.Write(inData, 0, inData.Length);
                        cs.FlushFinalBlock();
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }
        }
        public string Decrypt(string encryptedString)
        {
            byte[] btKey = Encoding.Default.GetBytes(_key);
            byte[] btIv = Encoding.Default.GetBytes(_iv);
            var des = new DESCryptoServiceProvider();
            using (var ms = new MemoryStream())
            {
                try
                {
                    byte[] inData = Convert.FromBase64String(encryptedString);
                    using (var cs = new CryptoStream(ms, des.CreateDecryptor(btKey, btIv), CryptoStreamMode.Write))
                    {
                        cs.Write(inData,0,inData.Length);
                        cs.FlushFinalBlock();
                    }
                    return Encoding.Default.GetString(ms.ToArray());
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message,ex);
                }
            }
        }
    }
}
