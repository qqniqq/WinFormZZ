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

        private void btnCipher_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKeyToEncrypt.Text) && !string.IsNullOrEmpty(txtToEncrypt.Text))
            {
                output = Cipher.Encrypt(txtToEncrypt.Text, int.Parse(txtKeyToEncrypt.Text));

                txtEncryptedText.Text = output;
            }
        }

        private void btnDecipher_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKeyToEncrypt.Text) && !string.IsNullOrEmpty(txtTextToDecrypt.Text))
            {
                int key;
                if (int.TryParse(txtKeyToEncrypt.Text, out key))  
                {
                    output = Cipher.Decrypt(txtTextToDecrypt.Text, key);

                    txtDecryptedText.Text = output;
                }
                else
                {
                    MessageBox.Show("Введите корректный ключ для расшифровки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
    }
}
