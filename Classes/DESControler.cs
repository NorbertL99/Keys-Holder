using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KeysHolder.Classes
{
    class DESControler
    {
        #region VARIABLES
        private static byte[] KEY_BYTES = Encoding.ASCII.GetBytes("aaaaaaaa");
        private static byte[] IV_BYTES = Encoding.ASCII.GetBytes("aaaaaaaa");
        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// Basic constructor, empty
        /// </summary>
        public DESControler()
        {

        }
        #endregion

        #region METHODS
        /// <summary>
        /// This method is used to encrypt with DES
        /// </summary>
        /// <param name="_text">Text to encrypt</param>
        /// <returns>Encrypted text</returns>
        public string DESEncryption(string _text)
        {
            string _finalEncryption = string.Empty;
            byte[] textBytes = Encoding.ASCII.GetBytes(_text);

            using (DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider())
            {
                cryptoServiceProvider.KeySize = 64;
                cryptoServiceProvider.BlockSize = 64;

                MemoryStream memoryStream = new MemoryStream();
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoServiceProvider.CreateEncryptor(KEY_BYTES, IV_BYTES), CryptoStreamMode.Write))
                {
                    StreamWriter streamWriter = new StreamWriter(cryptoStream);
                    streamWriter.Write(_text);
                    streamWriter.Flush();
                    cryptoStream.FlushFinalBlock();
                    _finalEncryption = Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
                }
            }
            return _finalEncryption;
        }

        /// <summary>
        /// This method is used to decrypt with DES
        /// </summary>
        /// <param name="_encryptedText">Encrypted text</param>
        /// <returns>Decrypted text</returns>
        public string DESDecryption(string _encryptedText)
        {
            string _finalDecryption = string.Empty;
            if (_encryptedText == null)
                return null;
            byte[] encryptedPlainTextBytes = Encoding.ASCII.GetBytes(_encryptedText);

            using (DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider())
            {
                cryptoServiceProvider.KeySize = 64;
                cryptoServiceProvider.BlockSize = 64;

                MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(_encryptedText));
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoServiceProvider.CreateDecryptor(KEY_BYTES, IV_BYTES), CryptoStreamMode.Read))
                {
                    StreamReader streamReader = new StreamReader(cryptoStream);
                    _finalDecryption = streamReader.ReadToEnd();
                }
            }
            return _finalDecryption;
        }
        #endregion
    }
}
