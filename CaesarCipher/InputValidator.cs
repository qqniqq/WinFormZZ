using System.Windows.Forms;

namespace CaesarCipher
{
    public static class InputValidator
    {
        public static bool ValidateText(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Сначала введите текст для зашифровки.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        public static bool ValidateFile(string key, string alphabet, string text)
        {
            if (string.IsNullOrWhiteSpace(key) ||
                string.IsNullOrWhiteSpace(alphabet) ||
                string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Ошибка: файл не соответствует требуемому формату.",
                    "Некорректный файл", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
