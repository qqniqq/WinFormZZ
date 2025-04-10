using CaesarCipher;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CaesarCipherTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void Encrypt_ValidInput_ReturnsEncryptedText()
        {
            string text = "hello";
            int key = 3;
            string expected = "khoor";

            string result = Cipher.Encrypt(text, key);

            Assert.AreEqual(expected, result);
        }


    }
}

