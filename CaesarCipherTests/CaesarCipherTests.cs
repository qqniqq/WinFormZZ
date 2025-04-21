﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaesarCipher;
using System;

namespace CaesarCipherTests
{
    [TestClass]
    public class CipherTests
    {
        [TestMethod]
        [DataRow("привет я Саид мне 19 лет", "3", "тулезх 2 Фглж прз 4C озх", "encrypt")]
        [DataRow("Jk, K'o Uckf, K'o 3B Аgctu qnf", "2", "Hi, I'm Said, I'm 19 years old", "decrypt")]
        [DataRow("Привет", "-3", null, "negative_key")]
        [DataRow("Hello", "4", "Lipps", "latin")]
        [DataRow("Привет", "5", "Фхнжйч", "cyrillic")]
        [DataRow("2025", "1", "3136", "numbers")]
        [DataRow("Здравствуйте, мне 8", "0", "Здравствуйте, мне 8", "zero_key")]
        [DataRow("Привет", "abc", null, "invalid_key")]
        public void TestCipherCases(string input, string keyString, string expected, string testType)
        {
            int key = 0;
            bool parsed = int.TryParse(keyString, out key);
            if (testType == "invalid_key")
            {
                Assert.IsFalse(parsed, "Ожидалась ошибка при некорректном ключе.");
                return;
            }
            switch (testType)
            {
                case "encrypt":
                    string encrypted = Cipher.Encrypt(input, key);
                    Assert.AreEqual(expected, encrypted, "Шифрование не совпадает с ожидаемым результатом.");
                    break;
                case "decrypt":
                    string decrypted = Cipher.Decrypt(input, key);
                    Assert.AreEqual(expected, decrypted, "Дешифровка не совпадает с ожидаемым результатом.");
                    break;
                case "negative_key":
                case "latin":
                case "cyrillic":
                case "numbers":
                    string result = Cipher.Encrypt(input, key);
                    Assert.AreNotEqual(input, result, "Шифрование должно изменять исходную строку.");
                    break;
                case "zero_key":
                    string zeroKeyResult = Cipher.Encrypt(input, key);
                    Assert.AreEqual(input, zeroKeyResult, "При ключе 0 результат должен совпадать с исходным текстом.");
                    break;
                default:
                    Assert.Fail("Неизвестный тип теста.");
                    break;
            }
        }
    }
}
