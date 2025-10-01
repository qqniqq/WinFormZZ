using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Net;
using System.Text;
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

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            string key = "1";
            string alphabet = "Русский";
            string encryptedText = "";

            string extension = Path.GetExtension(openFileDialog.FileName).ToLower();

            if (extension == ".html")
            {
                string html = File.ReadAllText(openFileDialog.FileName, Encoding.UTF8);

                // ищем ALPHABET
                var mAlphabet = Regex.Match(html, @"<b>\s*Алфавит:\s*</b>\s*(.+?)</p>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                if (mAlphabet.Success)
                    alphabet = WebUtility.HtmlDecode(mAlphabet.Groups[1].Value).Trim();

                // ищем KEY
                var mKey = Regex.Match(html, @"<b>\s*Ключ:\s*</b>\s*(.+?)</p>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                if (mKey.Success)
                    key = WebUtility.HtmlDecode(mKey.Groups[1].Value).Trim();

                // ищем TEXT внутри <pre>...</pre>
                var mText = Regex.Match(html, @"<pre>(.*?)</pre>", RegexOptions.Singleline | RegexOptions.IgnoreCase);
                if (mText.Success)
                    encryptedText = WebUtility.HtmlDecode(mText.Groups[1].Value);
                else
                {
                    var mText2 = Regex.Match(html, @"<b>\s*Текст:\s*</b>\s*(.+?)</p>", RegexOptions.Singleline | RegexOptions.IgnoreCase);
                    if (mText2.Success)
                        encryptedText = WebUtility.HtmlDecode(mText2.Groups[1].Value);
                }
            }
            else 
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName, Encoding.UTF8);
                foreach (string line in lines)
                {
                    if (line.StartsWith("KEY="))
                        key = line.Substring(4).Trim();
                    else if (line.StartsWith("ALPHABET="))
                        alphabet = line.Substring(9).Trim();
                    else if (line.StartsWith("TEXT="))
                        encryptedText = line.Substring(5);
                }
            }

            if (alphabet.IndexOf("Англ", StringComparison.OrdinalIgnoreCase) >= 0 ||
                alphabet.IndexOf("English", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                cmbAlphabetDecrypt.SelectedItem = "Английский";
            }
            else
            {
                cmbAlphabetDecrypt.SelectedItem = "Русский";
            }

            // гарантируем, что список ключей обновлён (на случай, если событие не сработало)
            UpdateKeyCombo(cmbAlphabetDecrypt, cmbKeyDecrypt);
            // распарсить ключ как число и выбрать его в ComboBox
            int parsedKey;
            // извлечём первое число из строки (если там есть лишние символы)
            var numMatch = Regex.Match(key, @"\d+");
            if (numMatch.Success && int.TryParse(numMatch.Value, out parsedKey))
            {
                string keyStr = parsedKey.ToString();
                int keyIndex = cmbKeyDecrypt.Items.IndexOf(keyStr);
                if (keyIndex >= 0)
                    cmbKeyDecrypt.SelectedIndex = keyIndex;
                else
                {
                    // если вдруг не нашлось (неожиданно), оставляем значение 0 и сообщим
                    cmbKeyDecrypt.SelectedIndex = 0;
                }
            }
            else
            {
                // неверный формат ключа — ставим 0
                cmbKeyDecrypt.SelectedIndex = 0;
            }

            // Подставляем текст и выполняем расшифровку
            txtTextToDecrypt.Text = encryptedText ?? "";
            DecryptAndShow(txtTextToDecrypt, cmbKeyDecrypt, txtDecryptedText, cmbAlphabetDecrypt);
        
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

            cmbAlphabetDecrypt.SelectedItem = AppData.LastAlphabet == AlphabetType.English ? "Английский" : "Русский";
            UpdateKeyCombo(cmbAlphabetDecrypt, cmbKeyDecrypt);

            int prevKeyIndex = cmbKeyDecrypt.Items.IndexOf(AppData.LastKey.ToString());
            if (prevKeyIndex >= 0)
                cmbKeyDecrypt.SelectedIndex = prevKeyIndex;
            else
                cmbKeyDecrypt.SelectedIndex = 0;

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

    }
}
