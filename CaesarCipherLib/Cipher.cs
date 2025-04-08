using System;

namespace CaesarCipher
{
    public class Cipher
    {
        private static readonly string Alphabet =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" +
            "абвгдеёжзийклмнопрстуфхцчшщъыьэюя0123456789";

        public static string Encrypt(string textToEncrypt, int key)
        {
            if (string.IsNullOrEmpty(textToEncrypt))
                return string.Empty;

            char currentChar = textToEncrypt[0];
            int index = Alphabet.IndexOf(currentChar);

            char encryptedChar = currentChar;

            if (index != -1)
            {
                int newIndex = (index + key) % Alphabet.Length;
                encryptedChar = Alphabet[newIndex];
            }

            return encryptedChar + Encrypt(textToEncrypt.Substring(1), key);
        }

        public static string Decrypt(string textToDecrypt, int key)
        {
            if (string.IsNullOrEmpty(textToDecrypt))
                return string.Empty;

            char currentChar = textToDecrypt[0];
            int index = Alphabet.IndexOf(currentChar);

            char decryptedChar = currentChar;

            if (index != -1)
            {
                int newIndex = (index - key + Alphabet.Length) % Alphabet.Length;
                decryptedChar = Alphabet[newIndex];
            }

            return decryptedChar + Decrypt(textToDecrypt.Substring(1), key);
        }
    }
}
