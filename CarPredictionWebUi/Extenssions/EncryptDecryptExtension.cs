using System;
using System.Security.Cryptography;
using System.Text;

namespace CarPredictionWebUi.Extenssions
{
    public static class EncryptDecryptExtension
    {
        public static byte[] OptEntryopy;
        public static string Crypt(this string text)
        {
            return Convert.ToBase64String(
                ProtectedData.Protect(
                    Encoding.Unicode.GetBytes(text), OptEntryopy, DataProtectionScope.LocalMachine
                    ));
        }

        public static string Decrypt(this string text)
        {
            return Encoding.Unicode.GetString(
                ProtectedData.Unprotect(
                    Convert.FromBase64String(text), OptEntryopy, DataProtectionScope.LocalMachine));
        }
    }
}