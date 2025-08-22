using System;

namespace CaesarCipher
{
    public enum AlphabetType
    {
        English,
        Russian
    }

    public class Cipher
    {
        private const string EnglishUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string EnglishLower = "abcdefghijklmnopqrstuvwxyz";
        private const string RussianUpper = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private const string RussianLower = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public static string Encrypt(string textToEncrypt, int key, AlphabetType alphabetType)
        {
            return Process(textToEncrypt, key, alphabetType, true);
        }

        public static string Decrypt(string textToDecrypt, int key, AlphabetType alphabetType)
        {
            return Process(textToDecrypt, key, alphabetType, false);
        }

        private static string Process(string text, int key, AlphabetType alphabetType, bool encrypt)
        {
            char[] result = new char[text.Length];

            string upper, lower;
            if (alphabetType == AlphabetType.English)
            {
                upper = EnglishUpper;
                lower = EnglishLower;
            }
            else
            {
                upper = RussianUpper;
                lower = RussianLower;
            }

            int len = upper.Length; // одинаковая длина у верхнего и нижнего

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                int index;
                if ((index = upper.IndexOf(c)) != -1) // верхний регистр
                {
                    int shift = encrypt ? key : -key;
                    int newIndex = (index + shift + len) % len;
                    result[i] = upper[newIndex];
                }
                else if ((index = lower.IndexOf(c)) != -1) // нижний регистр
                {
                    int shift = encrypt ? key : -key;
                    int newIndex = (index + shift + len) % len;
                    result[i] = lower[newIndex];
                }
                else
                {
                    // пробелы, цифры, знаки
                    result[i] = c;
                }
            }

            return new string(result);
        }
    }
}
