using CarPredictionWebUi.Extenssions;
using System;
using Xunit;

namespace CarPredictionUnitTests
{
    public class EncryptionTests
    {
        [Fact]
        public void EncryptDecryptTest()
        {
            var password = "admin";
            var encryptedPassword = password.Crypt();
            var decryptedPassword = encryptedPassword.Decrypt();

            Assert.Equal(password, decryptedPassword);
        }
    }
}
