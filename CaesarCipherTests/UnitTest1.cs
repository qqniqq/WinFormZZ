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



        [TestMethod]
        public void Decrypt_ValidInput_ReturnsDecryptedText()
        {
            string text = "khoor";
            int key = 3;
            string expected = "hello";

            string result = Cipher.Decrypt(text, key);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Encrypt_EmptyString_ReturnsEmptyString()
        {
            string text = "";
            int key = 3;
            string expected = "";

            string result = Cipher.Encrypt(text, key);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Decrypt_EmptyString_ReturnsEmptyString()
        {
            string text = "";
            int key = 3;
            string expected = "";

            string result = Cipher.Decrypt(text, key);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Encrypt_WithNonAlphabeticCharacters_ReturnsUnchanged()
        {
            string text = "hello, world!";
            int key = 3;
            string expected = "khoor, zruog!";

            string result = Cipher.Encrypt(text, key);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Decrypt_WithNonAlphabeticCharacters_ReturnsUnchanged()
        {
            string text = "khoor, zruog!";
            int key = 3;
            string expected = "hello, world!";

            string result = Cipher.Decrypt(text, key);

            Assert.AreEqual(expected, result);
        }
    }
}

