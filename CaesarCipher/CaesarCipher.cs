using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class CaesarCipher: Form
    {
        private string output;
        public CaesarCipher()
        {
            InitializeComponent();
            ClearControlsEncrypt();
            ClearControlsDecrypt();
        }

        public void ClearControlsEncrypt()
        {

            txtEncryptedText.Text = "";
            txtKeyToEncrypt.Text = "";
            txtToEncrypt.Text = "";
        }

        public void ClearControlsDecrypt()
        {
            txtDecryptedText.Text = "";
            txtKeyToDecrypt.Text = "";
            txtTextToDecrypt.Text = "";
        }

        private void CaesarCipher_Load(object sender, EventArgs e)
        {

        }

        private void IblKey_Click(object sender, EventArgs e)
        {

        }

        private void btnClearControls_Click(object sender, EventArgs e)
        {
            ClearControlsEncrypt();
        }

        private void btnCleaerControlsDecrypt_Click(object sender, EventArgs e)
        {
            ClearControlsDecrypt();
        }

        //универс фунцкции
        private bool TryGetKey(TextBox textBox, out int key)
        {
            if (int.TryParse(textBox.Text, out key))
                return true;

            MessageBox.Show("Введите корректный ключ!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private bool ValidateKey(int key, string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;

            char firstChar = text[0];

            // Проверяем латиницу
            if ((firstChar >= 'A' && firstChar <= 'Z') || (firstChar >= 'a' && firstChar <= 'z'))
            {
                if (key > 26)
                {
                    MessageBox.Show("Ключ не может быть больше 26 для английского алфавита!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            // Проверяем кириллицу
            else if ((firstChar >= 'А' && firstChar <= 'я') || firstChar == 'Ё' || firstChar == 'ё')
            {
                if (key > 33)
                {
                    MessageBox.Show("Ключ не может быть больше 33 для русского алфавита!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void EncryptAndShow(TextBox sourceText, TextBox keyText, TextBox outputText)
        {
            if (string.IsNullOrWhiteSpace(sourceText.Text)) return;
            if (!TryGetKey(keyText, out var key)) return;
            if (!ValidateKey(key, sourceText.Text)) return;

            output = Cipher.Encrypt(sourceText.Text, key);
            outputText.Text = output;


            // Сохраняем в AppData для расшифровки
            AppData.LastEncryptedText = output;
            AppData.LastKey = key;
        }

        private void DecryptAndShow(TextBox sourceText, TextBox keyText, TextBox outputText)
        {
            if (string.IsNullOrWhiteSpace(sourceText.Text)) return;
            if (!TryGetKey(keyText, out var key)) return;
            if (!ValidateKey(key, sourceText.Text)) return;

            output = Cipher.Decrypt(sourceText.Text, key);
            outputText.Text = output;
        }


        private void btnCipher_Click(object sender, EventArgs e)
        {
            EncryptAndShow(txtToEncrypt, txtKeyToEncrypt, txtEncryptedText);
        }

        private void btnDecipher_Click(object sender, EventArgs e)
        {
            DecryptAndShow(txtTextToDecrypt, txtKeyToDecrypt, txtDecryptedText);
        }

        private void txtKeyToEncrypt_TextChanged(object sender, EventArgs e)
        {
        
       
    }

        private void txtKeyToEncrypt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtKeyToDecrypt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Создаем диалоговое окно для выбора файла
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";  // Устанавливаем фильтр для типов файлов
            saveFileDialog.Title = "Сохранить зашифрованный текст";  // Заголовок окна

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Получаем путь и сохраняем зашифрованный текст в выбранный файл
                System.IO.File.WriteAllText(saveFileDialog.FileName, txtEncryptedText.Text);  // txtEncrypted - текст из TextBox с зашифрованным текстом
                MessageBox.Show("Результат успешно сохранён!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);  // Уведомление
            }
        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void lblDecrypt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoadForDecryption_Click(object sender, EventArgs e)
        {
            // Создаем диалог для открытия файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // Фильтры для выбора текстовых файлов
            openFileDialog.Title = "Выберите файл для расшифровки"; // Заголовок окна

            // Проверяем, выбрал ли пользователь файл
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Читаем содержимое выбранного файла
                string encryptedText = System.IO.File.ReadAllText(openFileDialog.FileName);

                // Получаем ключ для расшифровки (предполагаем, что он введен в TextBox)
                int key;
                if (int.TryParse(txtKeyToEncrypt.Text, out key)) // Преобразуем введённый ключ в число
                {
                    // Расшифровываем текст с использованием ключа
                    string decryptedText = Cipher.Decrypt(encryptedText, key);  // Используем метод расшифровки из  класса Cipher

                    // Выводим расшифрованный текст в TextBox
                    txtDecryptedText.Text = decryptedText; // txtDecrypted - TextBox, куда выводится результат
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите правильный ключ для расшифровки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUsePrevious_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AppData.LastEncryptedText))
            {
                MessageBox.Show("Нет сохранённого зашифрованного текста.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtTextToDecrypt.Text = AppData.LastEncryptedText;
            txtKeyToDecrypt.Text = AppData.LastKey.ToString();

            DecryptAndShow(txtTextToDecrypt, txtKeyToDecrypt, txtDecryptedText);
        }
    }
}
