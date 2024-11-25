using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MauiYouTubeDownload.Services
{
    class EncServices
    {
        public static string Encrypt(string plainText, string key)
        {
            try
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32)); // Ensure key is 32 bytes
                    aes.IV = new byte[16]; // Use a zero IV for simplicity (not recommended for production)

                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                            cryptoStream.Write(plainBytes, 0, plainBytes.Length);
                        }
                        return Convert.ToBase64String(memoryStream.ToArray());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"one or more values is not valid {ex.Message}");

            }
            return string.Empty;

        }

        // Decrypt a string
        public static string Decrypt(string encryptedText, string key)
        {
            try
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32)); // Ensure key is 32 bytes
                    aes.IV = new byte[16]; // Use a zero IV for simplicity (must match encryption)

                    using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(encryptedText)))
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            using (StreamReader reader = new StreamReader(cryptoStream))
                            {
                                return reader.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"one or more values is not valid check you key {ex.Message}");
            }
            return string.Empty;


        }
    }
}
