using System.Linq;
using System.Text;

namespace CaesarCipher
{
    public enum AlphabetType
    {
        English,
        Russian
    }

    public class Cipher
    {
        private static readonly string EnglishUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly string EnglishLower = "abcdefghijklmnopqrstuvwxyz";
        private static readonly string Digits = "0123456789";

        private static readonly string RussianUpper = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private static readonly string RussianLower = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public static string Encrypt(string textToEncrypt, int key, AlphabetType alphabetType)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in textToEncrypt)
            {
                if (alphabetType == AlphabetType.English)
                {
                    if (EnglishUpper.Contains(c))
                        result.Append(EnglishUpper[(EnglishUpper.IndexOf(c) + key) % EnglishUpper.Length]);
                    else if (EnglishLower.Contains(c))
                        result.Append(EnglishLower[(EnglishLower.IndexOf(c) + key) % EnglishLower.Length]);
                    else if (Digits.Contains(c))
                        result.Append(Digits[(Digits.IndexOf(c) + key) % Digits.Length]);
                    else
                        result.Append(c);
                }
                else // рус
                {
                    if (RussianUpper.Contains(c))
                        result.Append(RussianUpper[(RussianUpper.IndexOf(c) + key) % RussianUpper.Length]);
                    else if (RussianLower.Contains(c))
                        result.Append(RussianLower[(RussianLower.IndexOf(c) + key) % RussianLower.Length]);
                    else if (Digits.Contains(c))
                        result.Append(Digits[(Digits.IndexOf(c) + key) % Digits.Length]);
                    else
                        result.Append(c);
                }
            }

            return result.ToString();
        }

        public static string Decrypt(string textToDecrypt, int key, AlphabetType alphabetType)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in textToDecrypt)
            {
                if (alphabetType == AlphabetType.English)
                {
                    if (EnglishUpper.Contains(c))
                        result.Append(EnglishUpper[(EnglishUpper.IndexOf(c) - key + EnglishUpper.Length) % EnglishUpper.Length]);
                    else if (EnglishLower.Contains(c))
                        result.Append(EnglishLower[(EnglishLower.IndexOf(c) - key + EnglishLower.Length) % EnglishLower.Length]);
                    else if (Digits.Contains(c))
                        result.Append(Digits[(Digits.IndexOf(c) - key + Digits.Length) % Digits.Length]);
                    else
                        result.Append(c);
                }
                else //рус
                {
                    if (RussianUpper.Contains(c))
                        result.Append(RussianUpper[(RussianUpper.IndexOf(c) - key + RussianUpper.Length) % RussianUpper.Length]);
                    else if (RussianLower.Contains(c))
                        result.Append(RussianLower[(RussianLower.IndexOf(c) - key + RussianLower.Length) % RussianLower.Length]);
                    else if (Digits.Contains(c))
                        result.Append(Digits[(Digits.IndexOf(c) - key + Digits.Length) % Digits.Length]);
                    else
                        result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}
