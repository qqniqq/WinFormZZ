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

            // блокируем ручной ввод в комбобоксах
            cmbAlphabet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlphabetDecrypt.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKeyEncrypt.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKeyDecrypt.DropDownStyle = ComboBoxStyle.DropDownList;
            // блокируем редактирование результата руками
            txtEncryptedText.ReadOnly = true;
            txtDecryptedText.ReadOnly = true;
            // изначально кнопка "Сохранить" выключена
            buttonSave.Enabled = false;
        }

        public void ClearControlsEncrypt()
        {
            txtEncryptedText.Text = "";
            txtToEncrypt.Text = "";
            cmbKeyEncrypt.SelectedIndex = -1;
            buttonSave.Enabled = false;
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

        private AlphabetType GetSelectedAlphabet(ComboBox combo)
        {
            return (combo.SelectedItem != null && combo.SelectedItem.ToString().Contains("Англ"))
                ? AlphabetType.English
                : AlphabetType.Russian;
        }



        private void EncryptAndShow(TextBox sourceText, ComboBox keyCombo, TextBox outputText, ComboBox alphabetCombo)
        {
            bool textEmpty = string.IsNullOrWhiteSpace(sourceText.Text);
            bool keyEmpty = (keyCombo.SelectedItem == null);

            // Оба пусты
            if (textEmpty && keyEmpty)
            {
                MessageBox.Show("Сначала введите ключ и текст для зашифровки", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                sourceText.Focus();
                keyCombo.DroppedDown = true; // подсказка выбрать ключ
                return;
            }

            // По отдельности
            if (textEmpty)
            {
                MessageBox.Show("Сначала введите текст для зашифрования", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                sourceText.Focus();
                return;
            }

            if (keyEmpty)
            {
                MessageBox.Show("Сначала выберите ключ", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                keyCombo.Focus();
                keyCombo.DroppedDown = true;
                return;
            }

            int key = int.Parse(keyCombo.SelectedItem.ToString());
            var alphabetType = GetSelectedAlphabet(alphabetCombo);

            output = Cipher.Encrypt(sourceText.Text, key, alphabetType);
            outputText.Text = output;

            AppData.LastEncryptedText = output;
            AppData.LastKey = key;

            buttonSave.Enabled = true; // активируем "Сохранить"
        }

        private void DecryptAndShow(TextBox sourceText, ComboBox keyCombo, TextBox outputText, ComboBox alphabetCombo)
        {
            bool textEmpty = string.IsNullOrWhiteSpace(sourceText.Text);
            bool keyEmpty = (keyCombo.SelectedItem == null);

            // Оба пусты
            if (textEmpty && keyEmpty)
            {
                MessageBox.Show("Сначала выберите ключ и введите текст для расшифровки", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                sourceText.Focus();
                keyCombo.DroppedDown = true; // подсказка ключ
                return;
            }

            // По отдельности
            if (textEmpty)
            {
                MessageBox.Show("Сначала введите текст для расшифровки", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                sourceText.Focus();
                return;
            }

            if (keyEmpty)
            {
                MessageBox.Show("Сначала выберите ключ", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                keyCombo.Focus();
                keyCombo.DroppedDown = true;
                return;
            }

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
            if (string.IsNullOrEmpty(txtEncryptedText.Text))
            {
                MessageBox.Show("Нет результата для сохранения!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Сохранить зашифрованный текст"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, txtEncryptedText.Text);
                MessageBox.Show("Результат успешно сохранён!", "Готово",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
