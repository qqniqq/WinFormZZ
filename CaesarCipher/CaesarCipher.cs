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
            ResetEncryptControls();
            ResetDecryptControls();

            //блокируем ручной ввод в комбобоксах
            cmbAlphabet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlphabetDecrypt.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKeyEncrypt.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKeyDecrypt.DropDownStyle = ComboBoxStyle.DropDownList;
            //блокируем редактирование результата 
            txtEncryptedText.ReadOnly = true;
            txtDecryptedText.ReadOnly = true;
            //изначально кнопка Сохранить выключена
            buttonSave.Enabled = false;
        }


        private void CaesarCipher_Load(object sender, EventArgs e)
        {
            string[] langs = { "Русский", "Английский" };

            cmbAlphabet.Items.Clear();
            cmbAlphabet.Items.AddRange(langs);
            cmbAlphabet.SelectedIndex = 0;
            cmbAlphabet.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbAlphabetDecrypt.Items.Clear();
            cmbAlphabetDecrypt.Items.AddRange(langs);
            cmbAlphabetDecrypt.SelectedIndex = 0;
            cmbAlphabetDecrypt.DropDownStyle = ComboBoxStyle.DropDownList;

            UpdateKeyCombo(cmbAlphabet, cmbKeyEncrypt);
            UpdateKeyCombo(cmbAlphabetDecrypt, cmbKeyDecrypt);

            cmbAlphabet.SelectedIndexChanged += (s, ev) => UpdateKeyCombo(cmbAlphabet, cmbKeyEncrypt);
            cmbAlphabetDecrypt.SelectedIndexChanged += (s, ev) => UpdateKeyCombo(cmbAlphabetDecrypt, cmbKeyDecrypt);

            cmbKeyEncrypt.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKeyDecrypt.DropDownStyle = ComboBoxStyle.DropDownList;

            txtEncryptedText.ReadOnly = true;
            txtDecryptedText.ReadOnly = true;

            this.BeginInvoke((MethodInvoker)(() => txtToEncrypt.Focus()));
        }

        private void UpdateKeyCombo(ComboBox languageCombo, ComboBox keyCombo)
        {
            keyCombo.Items.Clear();
            int max = (languageCombo.SelectedItem != null &&
                       languageCombo.SelectedItem.ToString().Contains("Англ")) ? 26 : 33;

            for (int i = 1; i <= max; i++)
                keyCombo.Items.Add(i.ToString());

            keyCombo.SelectedIndex = 0;
        }

        private void IblKey_Click(object sender, EventArgs e)
        {

        }

        private void ResetEncryptControls()
        {
            txtEncryptedText.Text = "";
            txtToEncrypt.Text = "";
            cmbAlphabet.SelectedIndex = 0;
            cmbKeyEncrypt.SelectedIndex = 0;
            buttonSave.Enabled = false; //отключаем сохранение, пока нет нового результата
            txtToEncrypt.Focus();
        }
        private void ResetDecryptControls()
        {
            txtDecryptedText.Text = "";
            txtTextToDecrypt.Text = "";
            cmbAlphabetDecrypt.SelectedIndex = 0;
            cmbKeyDecrypt.SelectedIndex = 0;
            txtTextToDecrypt.Focus();
        }

        private void btnClearControls_Click(object sender, EventArgs e)
        {
            ResetEncryptControls();
        }

        private void btnCleaerControlsDecrypt_Click(object sender, EventArgs e)
        {
            ResetDecryptControls();
        }

        private AlphabetType GetSelectedAlphabet(ComboBox combo)
        {
            return (combo.SelectedItem != null && combo.SelectedItem.ToString().Contains("Англ"))
                ? AlphabetType.English
                : AlphabetType.Russian;
        }

        private bool ValidateInputs(TextBox textBox, ComboBox keyCombo, string actionName)
        {
            bool textEmpty = string.IsNullOrWhiteSpace(textBox.Text);
            bool keyEmpty = (keyCombo.SelectedItem == null);

            if (textEmpty && keyEmpty)
            {
                MessageBox.Show($"Сначала введите ключ и текст для {actionName}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textEmpty)
            {
                MessageBox.Show($"Сначала введите текст для {actionName}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (keyEmpty)
            {
                MessageBox.Show("Сначала выберите ключ", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                keyCombo.Focus();
                keyCombo.DroppedDown = true;
                return false;
            }

            return true;
        }



        private void EncryptAndShow(TextBox sourceText, ComboBox keyCombo, TextBox outputText, ComboBox alphabetCombo)
        {
            if (!ValidateInputs(sourceText, keyCombo, "зашифровки")) return;

            int key = int.Parse(keyCombo.SelectedItem.ToString());
            var alphabetType = GetSelectedAlphabet(alphabetCombo);

            output = Cipher.Encrypt(sourceText.Text, key, alphabetType);
            outputText.Text = output;

            AppData.LastEncryptedText = output;
            AppData.LastKey = key;
            AppData.LastAlphabet = alphabetType;

            buttonSave.Enabled = true;
        }

        private void DecryptAndShow(TextBox sourceText, ComboBox keyCombo, TextBox outputText, ComboBox alphabetCombo)
        {
            if (!ValidateInputs(sourceText, keyCombo, "расшифровки")) return;

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
                MessageBox.Show("Нет данных для сохранения.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "HTML files (*.html)|*.html|Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Сохранить зашифрованный текст"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string alphabet = (cmbAlphabet.SelectedItem != null) ? cmbAlphabet.SelectedItem.ToString() : "Русский";
                string key = (cmbKeyEncrypt.SelectedItem != null) ? cmbKeyEncrypt.SelectedItem.ToString() : "1";
                string text = txtEncryptedText.Text;

                if (Path.GetExtension(saveFileDialog.FileName).ToLower() == ".html")
                {
                    string htmlContent = $@"
            <html>
            <head><meta charset='UTF-8'><title>Результат шифрования</title></head>
            <body>
                <h2>Результат шифрования</h2>
                <p><b>Алфавит:</b> {alphabet}</p>
                <p><b>Ключ:</b> {key}</p>
                <p><b>Текст:</b><br><pre>{text}</pre></p>
            </body>
            </html>";

                    File.WriteAllText(saveFileDialog.FileName, htmlContent, Encoding.UTF8);
                }
                else
                {
                    string content = $"KEY={key}\nALPHABET={alphabet}\nTEXT={text}";
                    File.WriteAllText(saveFileDialog.FileName, content, Encoding.UTF8);
                }

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
                Filter = "HTML files (*.html)|*.html|Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Выберите файл для расшифровки"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string key = "1";
                string alphabet = "Русский";
                string encryptedText = "";

                string extension = Path.GetExtension(openFileDialog.FileName).ToLower();

                if (extension == ".html")
                {
                    string html = File.ReadAllText(openFileDialog.FileName, Encoding.UTF8);

                    // Извлекаем KEY
                    int keyStart = html.IndexOf("<b>Ключ:</b>");
                    if (keyStart >= 0)
                    {
                        int keyEnd = html.IndexOf("</p>", keyStart);
                        key = html.Substring(keyStart, keyEnd - keyStart)
                                  .Replace("<b>Ключ:</b>", "")
                                  .Replace("<p>", "")
                                  .Replace("</p>", "")
                                  .Trim();
                    }

                    // Извлекаем ALPHABET
                    int alphabetStart = html.IndexOf("<b>Алфавит:</b>");
                    if (alphabetStart >= 0)
                    {
                        int alphabetEnd = html.IndexOf("</p>", alphabetStart);
                        alphabet = html.Substring(alphabetStart, alphabetEnd - alphabetStart)
                                       .Replace("<b>Алфавит:</b>", "")
                                       .Replace("<p>", "")
                                       .Replace("</p>", "")
                                       .Trim();
                    }

                    // Извлекаем TEXT
                    int textStart = html.IndexOf("<pre>");
                    if (textStart >= 0)
                    {
                        int textEnd = html.IndexOf("</pre>", textStart);
                        encryptedText = html.Substring(textStart + 5, textEnd - (textStart + 5));
                    }
                }
                else // txt файл
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    foreach (string line in lines)
                    {
                        if (line.StartsWith("KEY="))
                            key = line.Substring(4);
                        else if (line.StartsWith("ALPHABET="))
                            alphabet = line.Substring(9);
                        else if (line.StartsWith("TEXT="))
                            encryptedText = line.Substring(5);
                    }
                }

                txtTextToDecrypt.Text = encryptedText;

                // Устанавливаем ключ
                int keyIndex = cmbKeyDecrypt.Items.IndexOf(key);
                if (keyIndex >= 0)
                    cmbKeyDecrypt.SelectedIndex = keyIndex;

                // Устанавливаем алфавит
                if (alphabet.Contains("Англ"))
                    cmbAlphabetDecrypt.SelectedItem = "Английский";
                else
                    cmbAlphabetDecrypt.SelectedItem = "Русский";

                // авторасшифровка
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
            cmbKeyDecrypt.SelectedItem = AppData.LastKey.ToString();
            cmbAlphabetDecrypt.SelectedItem = AppData.LastAlphabet == AlphabetType.English ? "Английский" : "Русский";

            DecryptAndShow(txtTextToDecrypt, cmbKeyDecrypt, txtDecryptedText, cmbAlphabetDecrypt);
        }




        private void cmbKeyEncrypt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbKeyDecrypt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtToEncrypt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTextToDecrypt_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtTextToDecrypt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                e.SuppressKeyPress = true; //блокируем перенос строки
                btnDecipher.PerformClick(); //расшифровать enter
            }
        }

        private void txtToEncrypt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                e.SuppressKeyPress = true;
                btnCipher.PerformClick();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Зашифровка")
            {
                this.BeginInvoke((MethodInvoker)(() => txtToEncrypt.Focus()));
            }
            else if (tabControl1.SelectedTab.Text == "Расшифровка")
            {
                this.BeginInvoke((MethodInvoker)(() => txtTextToDecrypt.Focus()));
            }
        }

        private void buttonLoadForEncryption_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "HTML files (*.html)|*.html|Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Выберите файл для расшифровки"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string key = "1";
                string alphabet = "Русский";
                string encryptedText = "";

                string extension = Path.GetExtension(openFileDialog.FileName).ToLower();

                if (extension == ".html")
                {
                    string html = File.ReadAllText(openFileDialog.FileName, Encoding.UTF8);

                    // Извлекаем KEY
                    int keyStart = html.IndexOf("<b>Ключ:</b>");
                    if (keyStart >= 0)
                    {
                        int keyEnd = html.IndexOf("</p>", keyStart);
                        key = html.Substring(keyStart, keyEnd - keyStart)
                                  .Replace("<b>Ключ:</b>", "")
                                  .Replace("<p>", "")
                                  .Replace("</p>", "")
                                  .Trim();
                    }

                    // Извлекаем ALPHABET
                    int alphabetStart = html.IndexOf("<b>Алфавит:</b>");
                    if (alphabetStart >= 0)
                    {
                        int alphabetEnd = html.IndexOf("</p>", alphabetStart);
                        alphabet = html.Substring(alphabetStart, alphabetEnd - alphabetStart)
                                       .Replace("<b>Алфавит:</b>", "")
                                       .Replace("<p>", "")
                                       .Replace("</p>", "")
                                       .Trim();
                    }

                    // Извлекаем TEXT
                    int textStart = html.IndexOf("<pre>");
                    if (textStart >= 0)
                    {
                        int textEnd = html.IndexOf("</pre>", textStart);
                        encryptedText = html.Substring(textStart + 5, textEnd - (textStart + 5));
                    }
                }
                else // txt файл
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    foreach (string line in lines)
                    {
                        if (line.StartsWith("KEY="))
                            key = line.Substring(4);
                        else if (line.StartsWith("ALPHABET="))
                            alphabet = line.Substring(9);
                        else if (line.StartsWith("TEXT="))
                            encryptedText = line.Substring(5);
                    }
                }

                txtTextToDecrypt.Text = encryptedText;

                // Устанавливаем ключ
                int keyIndex = cmbKeyDecrypt.Items.IndexOf(key);
                if (keyIndex >= 0)
                    cmbKeyDecrypt.SelectedIndex = keyIndex;

                // Устанавливаем алфавит
                if (alphabet.Contains("Англ"))
                    cmbAlphabetDecrypt.SelectedItem = "Английский";
                else
                    cmbAlphabetDecrypt.SelectedItem = "Русский";

                // авторасшифровка
                DecryptAndShow(txtTextToDecrypt, cmbKeyDecrypt, txtDecryptedText, cmbAlphabetDecrypt);
            }
        }
    }
}
