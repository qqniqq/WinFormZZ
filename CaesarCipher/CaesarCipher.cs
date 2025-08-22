using System;
using System.IO;
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
            txtToEncrypt.Text = "";
            cmbKeyEncrypt.SelectedIndex = -1;
        }

        public void ClearControlsDecrypt()
        {
            txtDecryptedText.Text = "";
            txtTextToDecrypt.Text = "";
            cmbKeyDecrypt.SelectedIndex = -1;
        }

        private void CaesarCipher_Load(object sender, EventArgs e)
        {
            string[] langs = { "Русский", "Английский" };

            cmbAlphabet.Items.Clear();
            cmbAlphabet.Items.AddRange(langs);
            cmbAlphabet.SelectedIndex = 0;

            cmbAlphabetDecrypt.Items.Clear();
            cmbAlphabetDecrypt.Items.AddRange(langs);
            cmbAlphabetDecrypt.SelectedIndex = 0;

            UpdateKeyCombo(cmbAlphabet, cmbKeyEncrypt);
            UpdateKeyCombo(cmbAlphabetDecrypt, cmbKeyDecrypt);

            cmbAlphabet.SelectedIndexChanged += (s, ev) => UpdateKeyCombo(cmbAlphabet, cmbKeyEncrypt);
            cmbAlphabetDecrypt.SelectedIndexChanged += (s, ev) => UpdateKeyCombo(cmbAlphabetDecrypt, cmbKeyDecrypt);
        }
        private void UpdateKeyCombo(ComboBox languageCombo, ComboBox keyCombo)
        {
            keyCombo.Items.Clear();
            int max = (languageCombo.SelectedItem != null &&
                       languageCombo.SelectedItem.ToString().Contains("Англ")) ? 26 : 33;

            for (int i = 1; i <= max; i++)
            {
                keyCombo.Items.Add(i.ToString());
            }
            keyCombo.SelectedIndex = 0; // по умолчанию 1
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

        private AlphabetType GetSelectedAlphabet(ComboBox combo)
        {
            return (combo.SelectedItem != null && combo.SelectedItem.ToString().Contains("Англ"))
                ? AlphabetType.English
                : AlphabetType.Russian;
        }


        private void EncryptAndShow(TextBox sourceText, ComboBox keyCombo, TextBox outputText, ComboBox alphabetCombo)
        {
            if (string.IsNullOrWhiteSpace(sourceText.Text)) return;
            if (keyCombo.SelectedItem == null) return;

            int key = int.Parse(keyCombo.SelectedItem.ToString());
            var alphabetType = GetSelectedAlphabet(alphabetCombo);

            output = Cipher.Encrypt(sourceText.Text, key, alphabetType);
            outputText.Text = output;

            AppData.LastEncryptedText = output;
            AppData.LastKey = key;
        }

        private void DecryptAndShow(TextBox sourceText, ComboBox keyCombo, TextBox outputText, ComboBox alphabetCombo)
        {
            if (string.IsNullOrWhiteSpace(sourceText.Text)) return;
            if (keyCombo.SelectedItem == null) return;

            int key = int.Parse(keyCombo.SelectedItem.ToString());
            var alphabetType = GetSelectedAlphabet(alphabetCombo);

            output = Cipher.Decrypt(sourceText.Text, key, alphabetType);
            outputText.Text = output;
        }


        private void btnCipher_Click(object sender, EventArgs e)
        {
            EncryptAndShow(txtToEncrypt, cmbKeyEncrypt, txtEncryptedText, cmbAlphabet);
        }

        private void btnDecipher_Click(object sender, EventArgs e)
        {
            DecryptAndShow(txtTextToDecrypt, cmbKeyDecrypt, txtDecryptedText, cmbAlphabetDecrypt);
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
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Выберите файл для расшифровки"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string encryptedText = File.ReadAllText(openFileDialog.FileName);
                txtTextToDecrypt.Text = encryptedText;
                DecryptAndShow(txtTextToDecrypt, cmbKeyDecrypt, txtDecryptedText, cmbAlphabetDecrypt);
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

            // выставляем ключ, который был использован
            if (AppData.LastKey <= cmbKeyDecrypt.Items.Count)
            {
                cmbKeyDecrypt.SelectedItem = AppData.LastKey.ToString();
            }

            DecryptAndShow(txtTextToDecrypt, cmbKeyDecrypt, txtDecryptedText, cmbAlphabetDecrypt);
        }


        private void cmbKeyEncrypt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbKeyDecrypt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
