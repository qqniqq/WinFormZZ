using System.Linq;
using System.Text;

namespace CaesarCipher
{
    public enum AlphabetType
    {
        English,
        Russian,
        Digits
    }

    public class Cipher
    {
        private static readonly string EnglishUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly string EnglishLower = "abcdefghijklmnopqrstuvwxyz";
        private static readonly string DigitsChars = "0123456789";

        private static readonly string RussianUpper = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private static readonly string RussianLower = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public static string Encrypt(string textToEncrypt, int key, AlphabetType alphabetType)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in textToEncrypt)
            {
                switch (alphabetType)
                {
                    case AlphabetType.English:
                        if (EnglishUpper.Contains(c))
                            result.Append(EnglishUpper[(EnglishUpper.IndexOf(c) + key) % EnglishUpper.Length]);
                        else if (EnglishLower.Contains(c))
                            result.Append(EnglishLower[(EnglishLower.IndexOf(c) + key) % EnglishLower.Length]);
                        else
                            result.Append(c);
                        break;

                    case AlphabetType.Russian:
                        if (RussianUpper.Contains(c))
                            result.Append(RussianUpper[(RussianUpper.IndexOf(c) + key) % RussianUpper.Length]);
                        else if (RussianLower.Contains(c))
                            result.Append(RussianLower[(RussianLower.IndexOf(c) + key) % RussianLower.Length]);
                        else
                            result.Append(c);
                        break;

                    case AlphabetType.Digits:
                        if (DigitsChars.Contains(c))
                            result.Append(DigitsChars[(DigitsChars.IndexOf(c) + key) % DigitsChars.Length]);
                        else
                            result.Append(c);
                        break;
                }
            }

            return result.ToString();
        }

        public static string Decrypt(string textToDecrypt, int key, AlphabetType alphabetType)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in textToDecrypt)
            {
                switch (alphabetType)
                {
                    case AlphabetType.English:
                        if (EnglishUpper.Contains(c))
                            result.Append(EnglishUpper[(EnglishUpper.IndexOf(c) - key + EnglishUpper.Length) % EnglishUpper.Length]);
                        else if (EnglishLower.Contains(c))
                            result.Append(EnglishLower[(EnglishLower.IndexOf(c) - key + EnglishLower.Length) % EnglishLower.Length]);
                        else
                            result.Append(c);
                        break;

                    case AlphabetType.Russian:
                        if (RussianUpper.Contains(c))
                            result.Append(RussianUpper[(RussianUpper.IndexOf(c) - key + RussianUpper.Length) % RussianUpper.Length]);
                        else if (RussianLower.Contains(c))
                            result.Append(RussianLower[(RussianLower.IndexOf(c) - key + RussianLower.Length) % RussianLower.Length]);
                        else
                            result.Append(c);
                        break;

                    case AlphabetType.Digits:
                        if (DigitsChars.Contains(c))
                            result.Append(DigitsChars[(DigitsChars.IndexOf(c) - key + DigitsChars.Length) % DigitsChars.Length]);
                        else
                            result.Append(c);
                        break;
                }
            }
            return result.ToString();
        }

           
        }
    }

