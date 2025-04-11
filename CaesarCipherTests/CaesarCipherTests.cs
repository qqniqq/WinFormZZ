using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaesarCipher; 

namespace CaesarCipherTests
{
    [TestClass]
    public class CipherTests
    {
        [TestMethod]
        [DataRow("привет я Саид мне 19 лет", 2, "сткджф 1 Увкё опж 3B нжф")]
        public void TestEncrypt(string input, int key, string expected)
        {
            string result = Cipher.Encrypt(input, key);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("Jk, K'o Uckf, K'o 3B Аgctu qnf", 2, "Hi, I'm Said, I'm 19 years old")]
        public void TestDecrypt(string input, int key, string expected)
        {
            string result = Cipher.Decrypt(input, key);
            Assert.AreEqual(expected, result);
        }
    }
}
