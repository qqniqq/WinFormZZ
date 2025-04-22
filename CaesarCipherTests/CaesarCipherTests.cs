using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaesarCipher;

namespace CaesarCipherTests
{
    [TestClass]
    public class CipherTests
    {
        // Тест на шифрование
        [TestMethod]
        [DataRow("привет я Саид мне 19 лет", "3", "тулезх 2 Фглж прз 4C озх", "encrypt")]
        public void TestEncryption(string input, string keyString, string expected, string testType)
        {
            int key = int.Parse(keyString);
            string encrypted = Cipher.Encrypt(input, key);
            Assert.AreEqual(expected, encrypted, "Шифрование не совпадает с ожидаемым результатом.");
        }
        // Тест на дешифрование
        [TestMethod]
        [DataRow("Jk, K'o Uckf, K'o 3B Аgctu qnf", "2", "Hi, I'm Said, I'm 19 years old", "decrypt")]
        public void TestDecryption(string input, string keyString, string expected, string testType)
        {
            int key = int.Parse(keyString);
            string decrypted = Cipher.Decrypt(input, key);
            Assert.AreEqual(expected, decrypted, "Дешифровка не совпадает с ожидаемым результатом.");
        }
        // Тест для отрицательного ключа
        [TestMethod]
        [DataRow("Привет", "-3", null, "negative_key")]
        public void TestNegativeKey(string input, string keyString, string expected, string testType)
        {
            int key = int.Parse(keyString);
            string result = Cipher.Encrypt(input, key);
            Assert.AreNotEqual(input, result, "Шифрование должно изменять исходную строку.");
        }
        // Тест для латиницы
        [TestMethod]
        [DataRow("Hello", "4", "Lipps", "latin")]
        public void TestLatin(string input, string keyString, string expected, string testType)
        {
            int key = int.Parse(keyString);
            string encrypted = Cipher.Encrypt(input, key);
            Assert.AreEqual(expected, encrypted, "Шифрование латинского текста не совпадает с ожидаемым результатом.");
        }
        // Тест для кириллицы
        [TestMethod]
        [DataRow("Привет", "5", "Фхнжйч", "cyrillic")]
        public void TestCyrillic(string input, string keyString, string expected, string testType)
        {
            int key = int.Parse(keyString);
            string encrypted = Cipher.Encrypt(input, key);
            Assert.AreEqual(expected, encrypted, "Шифрование кириллицы не совпадает с ожидаемым результатом.");
        }
        // Тест для чисел
        [TestMethod]
        [DataRow("2025", "1", "3136", "numbers")]
        public void TestNumbers(string input, string keyString, string expected, string testType)
        {
            int key = int.Parse(keyString);
            string encrypted = Cipher.Encrypt(input, key);
            Assert.AreEqual(expected, encrypted, "Шифрование чисел не совпадает с ожидаемым результатом.");
        }
        // Тест для нулевого клЯюча
        [TestMethod]
        [DataRow("Здравствуйте, мне 8", "0", "Здравствуйте, мне 8", "zero_key")]
        public void TestZeroKey(string input, string keyString, string expected, string testType)
        {
            int key = int.Parse(keyString);
            string result = Cipher.Encrypt(input, key);
            Assert.AreEqual(input, result, "При ключе 0 результат должен совпадать с исходным текстом.");
        }
        // Тест для некорректного ключа
        [TestMethod]
        [DataRow("Привет", "abc", null, "invalid_key")]
        public void TestInvalidKey(string input, string keyString, string expected, string testType)
        {
            bool hasError = false;
            try
            {
                int key = int.Parse(keyString); // преобразование строки в число
            }
            catch
            {
                hasError = true; 
            }
            Assert.IsTrue(hasError, "Ожидалась ошибка при некорректном ключе.");
        }
    }
}
