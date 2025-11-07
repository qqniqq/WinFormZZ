using System;
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
            string[] langs = { "Русский", "Английский", "Цифры" };

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


            this.BeginInvoke((MethodInvoker)(() => txtToEncrypt.Focus()));
        }
        private void UpdateKeyCombo(ComboBox languageCombo, ComboBox keyCombo)
        {
            keyCombo.Items.Clear();

            int max = 0;

            if (languageCombo.SelectedItem.ToString().Contains("Англ"))
                max = 26;
            else if (languageCombo.SelectedItem.ToString().Contains("Рус"))
                max = 33;
            else if (languageCombo.SelectedItem.ToString().Contains("Цифры"))
                max = 10;

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
            string value = combo.SelectedItem.ToString();

            if (value.Contains("Англ"))
                return AlphabetType.English;
            if (value.Contains("Цифры"))
                return AlphabetType.Digits;

            return AlphabetType.Russian;
        }

        private void EncryptAndShow(TextBox sourceText, ComboBox keyCombo, TextBox outputText, ComboBox alphabetCombo)
        {
            if (!InputValidator.ValidateText(sourceText.Text))
                return;

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
            if (!InputValidator.ValidateText(sourceText.Text))
                return;

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
            if (!InputValidator.ValidateText(txtEncryptedText.Text))
                return;

            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "HTML files (*.html)|*.html|Text files (*.txt)|*.txt",
                Title = "Сохранить зашифрованный текст"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileManager.SaveFile(
                    dialog.FileName,
                    txtEncryptedText.Text,
                    cmbAlphabet.SelectedItem.ToString(),
                    cmbKeyEncrypt.SelectedItem.ToString()
                );
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
                Filter = "HTML files (*.html)|*.html|Text files (*.txt)|*.txt",
                Title = "Выберите файл для расшифровки"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            FileData data = FileManager.LoadFile(openFileDialog.FileName);

            if (!data.IsValid)
                return;

            txtTextToDecrypt.Text = data.Text;

            cmbAlphabetDecrypt.SelectedItem = data.Alphabet.Contains("Англ")
                ? "Английский"
                : data.Alphabet.Contains("Цифры")
                    ? "Цифры"
                    : "Русский";

            cmbKeyDecrypt.SelectedItem = data.Key;

            btnDecipher.PerformClick();
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
            cmbAlphabetDecrypt.SelectedItem =
                AppData.LastAlphabet == AlphabetType.English ? "Английский" :
                AppData.LastAlphabet == AlphabetType.Digits ? "Цифры" :
                "Русский";

            UpdateKeyCombo(cmbAlphabetDecrypt, cmbKeyDecrypt);
            cmbKeyDecrypt.SelectedItem = AppData.LastKey.ToString();

            btnDecipher.PerformClick();
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

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
